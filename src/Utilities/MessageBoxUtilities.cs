using Sunny.UI;

namespace SeewoHelper.Utilities
{
    public static class MessageBoxUtilities
    {
        /// <summary>
        /// 显示提示框
        /// </summary>
        public static bool Show(string text, string caption, bool showMask = false, UIMessageBoxButtons buttons = UIMessageBoxButtons.OK)
        {
            Program.Logger.Add($"显示消息框，参数：[text: {text}, caption: {caption}, showMask: {showMask}, buttons: {buttons}]");
            return UIMessageBox.Show(text, caption, Program.FormStyleController.CurrentStyle, buttons, showMask);
        }

        /// <summary>
        /// 显示询问信息提示框
        /// </summary>
        public static bool ShowAsk(string text, bool showMask = false)
        {
            return Show(text, "询问", showMask, UIMessageBoxButtons.OKCancel);
        }

        /// <summary>
        /// 显示错误信息提示框
        /// </summary>
        public static void ShowError(string text, bool showMask = false)
        {
            Show(text, "错误", showMask);
        }

        /// <summary>
        /// 显示信息提示框
        /// </summary>
        public static void ShowInfo(string text, bool showMask = false)
        {
            Show(text, "提示", showMask);
        }

        /// <summary>
        /// 显示成功信息提示框
        /// </summary>
        public static void ShowSuccess(string text, bool showMask = false)
        {
            Show(text, "成功", showMask);
        }

        /// <summary>
        /// 显示警告信息提示框
        /// </summary>
        public static void ShowWarning(string text, bool showMask = false)
        {
            Show(text, "警告", showMask);
        }
    }
}
