using System;
using System.Windows.Forms;

namespace SeewoHelper
{
    internal static class SystemExtensions
    {
        public static Exception ShowAndLog(this Exception ex, Logger logger, bool terminating = false)
        {
            MessageBox.Show($"程序给你抛出了异常，异常消息：\n{ex.Message}\n\n详细信息请查看日志，并提交 issue，有能力的话也可以发 pr 哦");
            logger.Add(ex.ToString(), terminating ? LogLevel.Fatal : LogLevel.Error);

            return ex;
        }
    }
}
