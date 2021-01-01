using SeewoHelper.Forms;
using SeewoHelper.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SeewoHelper
{
    static class Program
    {
        public static List<IDisposable> AutoDisposer { get; } = new List<IDisposable>();

        public static Logger Logger { get; private set; }

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!IsRunning())
            {
                Logger = new Logger(Path.Combine(Application.StartupPath, "Logs", DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".log"));

                Logger.Add("应用启动");

                AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
                AppDomain.CurrentDomain.ProcessExit += CurrentDomain_ProcessExit;

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new WindowMain());
            }
        }

        private static bool IsRunning()
        {
            var currentProcess = Process.GetCurrentProcess();
            var processes = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName);
            bool running = processes.Length > 1;

            if (running)
            {
                MessageBox.Show("该应用已在运行");
                var oldProcess = processes.Where(x => x.Id != currentProcess.Id).First();
                NativeMethods.SwitchToThisWindow(oldProcess.MainWindowHandle, true);
            }

            return running;
        }

        private static void CurrentDomain_ProcessExit(object sender, EventArgs e)
        {
            foreach (var disposable in AutoDisposer)
            {
                disposable.Dispose();
            }
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show($"程序给你抛出了异常，异常消息：\n{(e.ExceptionObject as Exception)?.Message ?? e.ExceptionObject}\n\n详细信息请查看日志，并提交 issue，有能力的话也可以发 pr 哦");
            Logger.Add(e.ExceptionObject.ToString(), e.IsTerminating ? LogLevel.Fatal : LogLevel.Error);
        }
    }
}
