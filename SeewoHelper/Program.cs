using System;
using System.Windows.Forms;

namespace SeewoHelper
{
    static class Program
    {
        public static readonly DisposableCollection DisposableCollection = new DisposableCollection();

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ApplicationExit += Application_ApplicationExit;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WindowMain());
        }

        private static void Application_ApplicationExit(object sender, EventArgs e)
        {
            DisposableCollection.Dispose();
        }
    }
}
