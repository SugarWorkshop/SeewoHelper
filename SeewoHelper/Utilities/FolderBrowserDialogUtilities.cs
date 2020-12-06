using System.Windows.Forms;

namespace SeewoHelper.Utilities
{
    internal static class FolderBrowserDialogUtilities
    {
        public static string GetFilePath(string description = "请选择文件夹")
        {
            var dialog = new FolderBrowserDialog() { Description = description };
            dialog.ShowDialog();

            return dialog.SelectedPath;
        }
    }
}
