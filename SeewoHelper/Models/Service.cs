using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ServiceProcess;
using System.Threading;
using System.Threading.Tasks;

namespace SeewoHelper
{
    public class Service
    {
        public string Name { get; }

        public bool Exists => _controller.ServiceName.ToLower() == Name.ToLower();

        public ServiceControllerStatus Status => Refresh().Status;

        public ServiceStartMode StartType => Refresh().StartType;

        private readonly ServiceController _controller;

        private static readonly Dictionary<ServiceStartMode, string> _serviceStartModeDictionary = new Dictionary<ServiceStartMode, string>()
        {
            [ServiceStartMode.Boot] = "boot",
            [ServiceStartMode.System] = "system",
            [ServiceStartMode.Automatic] = "auto",
            [ServiceStartMode.Manual] = "demand",
            [ServiceStartMode.Disabled] = "disabled"
        };

        private ServiceController Refresh()
        {
            _controller.Refresh();
            return _controller;
        }

        public async Task StartAsync()
        {
            _controller.Start();
            await Task.Run(() => _controller.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromMinutes(1)));

            Program.Logger.Add($"启动 {Name} 服务");
        }

        public async Task StopAsync() 
        {
            _controller.Stop();
            await Task.Run(() =>_controller.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromMinutes(1)));

            Program.Logger.Add($"停止 {Name} 服务");
        }

        public async Task SetStartModeAsync(ServiceStartMode startMode)
        {
            var processStartInfo = new ProcessStartInfo("sc.exe", $"config {Name} start= {_serviceStartModeDictionary[startMode]}") { CreateNoWindow = false, WindowStyle = ProcessWindowStyle.Hidden };
            await Process.Start(processStartInfo).WaitForExitAsync();

            Program.Logger.Add($"将 {Name} 服务的 StartType 调整为 {startMode}");
        }

        public Service(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            _controller = new ServiceController(name);
        }
    }
}
