using SeewoHelper.Forms;
using SeewoHelper.Utilities;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace SeewoHelper
{
    static class Program
    {
        public static Logger Logger { get; private set; } = new Logger(Path.Combine(Constants.BaseDirectory, "logs", DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".log"));

        public static FormStyleController FormStyleController { get; } = new FormStyleController();

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            using var mutex = new Mutex(true, Constants.AppName, out bool createdNew);

            FormStyleController.SetStyle(Configurations.UISettings.Content.Style);

            if (createdNew)
            {
                Application.ThreadException += Application_ThreadException; // 处理主线程的异常
                AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException; // 处理子线程未捕获异常

                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                Logger.Add("应用启动完毕");

                Application.Run(new WindowMain());
            }
            else
            {
                MessageBoxUtilities.ShowError("程序已经在运行了！");
            }
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            e.Exception.ShowAndLog(Logger);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            (e.ExceptionObject as Exception)?.ShowAndLog(Logger, e.IsTerminating);
        }
    }
}
