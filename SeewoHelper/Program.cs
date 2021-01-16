using SeewoHelper.Forms;
using SeewoHelper.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
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
            var instance = InstanceUtilities.GetRunningInstance();

            if (instance == null)
            {
                Logger = AutoDisposer.AddElement(new Logger(Path.Combine(Constants.BaseDirectory, "logs", DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".log")));

                Application.ThreadException += Application_ThreadException; // 处理主线程的异常

                AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException; // 处理子线程未捕获异常
                AppDomain.CurrentDomain.ProcessExit += CurrentDomain_ProcessExit;

                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                Logger.Add("应用启动");

                Application.Run(new WindowMain());
            }
            else
            {
                //InstanceUtilities.HandleRunningInstance(instance);
                MessageBox.Show("程序已经在运行了！");
            }
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            e.Exception.ShowAndLog(Logger);
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
            (e.ExceptionObject as Exception).ShowAndLog(Logger, e.IsTerminating);
        }
    }
}
