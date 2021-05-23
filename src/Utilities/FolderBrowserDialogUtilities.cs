using System.Windows.Forms;

namespace SeewoHelper.Utilities
{
    /// <summary>
    /// 提供 <see cref="FolderBrowserDialog"/> 相关的方法
    /// </summary>
    public static class FolderBrowserDialogUtilities
    {
        /// <summary>
        /// 获取文件路径
        /// </summary>
        /// <param name="description">描述</param>
        public static string GetFilePath(string description = "")
        {
            var dialog = new FolderBrowserDialog() { Description = description };
            dialog.ShowDialog();

            return dialog.SelectedPath.IsEmptyOrNull();
        }
    }
}
