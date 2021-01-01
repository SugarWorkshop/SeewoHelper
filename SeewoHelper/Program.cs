using SeewoHelper.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SeewoHelper
{
    static class Program
    {
        public static readonly List<IDisposable> AutoDisposer = new List<IDisposable>();

        public static readonly Logger Logger = new Logger(Path.Combine(Application.StartupPath, "Logs", DateTime.Now.ToString("yyyy-MM-ddTHH-mm-ss-fffffff") + ".log"));

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Logger.Add("应用启动");

            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            AppDomain.CurrentDomain.ProcessExit += CurrentDomain_ProcessExit;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WindowMain());
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
