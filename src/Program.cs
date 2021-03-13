using SeewoHelper.Forms;
using SeewoHelper.Utilities;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace SeewoHelper
{
    internal static class Program
    {
        public static Logger Logger { get; private set; }

        public static FormStyleController FormStyleController { get; } = new FormStyleController();

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            using var mutex = new Mutex(true, Constants.AppName, out bool createdNew); // 互斥锁，用于检测是否已运行有该程序实例

            if (createdNew)
            {
                Logger = new Logger(Path.Combine(Constants.LogPath, DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".log"));

                Application.ThreadException += Application_ThreadException; // 处理主线程的异常
                AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException; // 处理子线程未捕获异常

                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                FormStyleController.SetStyle(Configurations.UISettings.Content.Style); // 设置窗体风格

                Logger.Info("应用启动完毕");

                Application.Run(new WindowMain());
            }
            else
            {
                NativeMethods.PostMessage((IntPtr)NativeMethods.HWND_BROADCAST, NativeMethods.WM_SHOWWINDOW, IntPtr.Zero, IntPtr.Zero);
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
