using SeewoHelper.Forms;
using System;
using System.Threading;
using System.Windows.Forms;

namespace SeewoHelper
{
    static class Program
    {
        public static readonly DisposableCollection DisposableCollection = new DisposableCollection();

        public static MonitorableList<Log> Logger => Configurations.LoggerConfig.Content;

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Logger.Add(new Log("应用启动"));

            Application.ApplicationExit += Application_ApplicationExit;
            Application.ThreadException += Application_ThreadException;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WindowMain());
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            Logger.Add(new Log(e.Exception.ToString(), LogLevel.Fatal));
        }

        private static void Application_ApplicationExit(object sender, EventArgs e)
        {
            DisposableCollection.Dispose();
        }
    }
}
