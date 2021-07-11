using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeewoHelper
{
    public class PowerControlTask
    {
        private readonly Process _process;
        private readonly Task _task;
        private readonly Stopwatch _stopwatch = new();
        private readonly EventWaitHandle _eventWaitHandle = new(false, EventResetMode.AutoReset);

        public PowerControlTask(PowerControlType type, TimeSpan delay)
        {
            _process = type switch
            {
                PowerControlType.Shutdown => GetProcess("-s -t 0"),
                PowerControlType.Reboot => GetProcess("-r -t 0"),
                PowerControlType.Logout => GetProcess("-l -t 0"),
                _ => throw new ArgumentOutOfRangeException(nameof(type))
            };

            _task = new Task(HandleAsync, TaskCreationOptions.LongRunning);

            Delay = delay;
        }

        public TimeSpan Delay { get; }

        public TimeSpan Elapsed => _stopwatch.Elapsed;

        public bool IsStarted { get; private set; }

        public bool IsCancelled { get; private set; }

        public PowerControlTask Start()
        {
            if (IsStarted || IsCancelled)
            {
                throw new InvalidOperationException();
            }

            IsStarted = true;

            _stopwatch.Start();
            _task.Start();
            return this;
        }

        public void Cancel()
        {
            IsStarted = false;
            IsCancelled = true;

            _stopwatch.Stop();
            _stopwatch.Reset();
        }

        public void Wait()
        {
            if (!IsStarted)
            {
                throw new InvalidOperationException();
            }

            if (!_task.IsCompleted)
            {
                _eventWaitHandle.WaitOne();
            }

            _process.WaitForExit();
        }

        private static Process GetProcess(string arguments)
        {
            return new() { StartInfo = new ProcessStartInfo("shutdown.exe", arguments) };
        }

        private async void HandleAsync()
        {
            await Task.Delay(Delay);

            if (!IsCancelled)
            {
                _process.Start();
                _eventWaitHandle.Set();

                Cancel();
            }
        }
    }

    public enum PowerControlType
    {
        Shutdown,
        Reboot,
        Logout
    }
}
