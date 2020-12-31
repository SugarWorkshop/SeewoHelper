using SeewoHelper.Forms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Windows.Forms;

namespace SeewoHelper
{
    static class Program
    {
        public static readonly List<IDisposable> AutoDisposer = new List<IDisposable>();

        public static ObservableCollection<Log> Logger => Configurations.LoggerConfig.Content;

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Logger.Add(new Log("应用启动"));

            Application.ThreadExit += Application_ThreadExit;
            Application.ThreadException += Application_ThreadException;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WindowMain());
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show($"程序给你抛出了异常，异常消息：\n{e.Exception.Message}\n\n详细信息请查看日志，并提交 issue，有能力的话也可以发 pr 哦");
            Logger.Add(new Log(e.Exception.ToString(), LogLevel.Error));
        }

        private static void Application_ThreadExit(object sender, EventArgs e)
        {
            foreach (var disposable in AutoDisposer)
            {
                disposable.Dispose();
            }
        }
    }
}
