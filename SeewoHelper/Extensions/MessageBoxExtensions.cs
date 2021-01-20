using Sunny.UI;

namespace SeewoHelper
{
    internal class MessageBoxExtensions
    {
        public static bool Show(string text, string caption, bool showMask = false, UIMessageBoxButtons buttons = UIMessageBoxButtons.OK)
        {
            return UIMessageBox.Show(text, caption, Program.style.ProgramStyle, buttons, showMask);
        }
        public static bool ShowAsk(string text, bool showMask = false)
        {
            return Show(text, "询问", showMask, UIMessageBoxButtons.OKCancel);
        }
        public static void ShowError(string text, bool showMask = false)
        {
            Show(text, "错误", showMask);
        }
        public static void ShowInfo(string text, bool showMask = false)
        {
            Show(text, "提示", showMask);
        }
        public static void ShowSuccess(string text, bool showMask = false)
        {
            Show(text, "成功", showMask);
        }
        public static void ShowWarning(string text, bool showMask = false)
        {
            Show(text, "警告", showMask);
        }
    }
}
