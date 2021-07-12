using System.Windows.Forms;

namespace SeewoHelper
{
    /// <summary>
    /// 提供 <see cref="System.Windows.Forms"/> 命名空间下相关的扩展方法
    /// </summary>
    public static class FormsExtensions
    {
        /// <summary>
        /// 移除所有选中项
        /// </summary>
        /// <param name="collection">集合</param>
        public static void Remove(this ListView.SelectedListViewItemCollection collection)
        {
            foreach (ListViewItem item in collection)
            {
                item.Remove();
            }
        }

        /// <summary>
        /// 设置文本
        /// 若文本为 <see langword="null"/> 时显示默认文本并设置 <see cref="Control.Enabled"/> 为 <see langword="false"/>
        /// </summary>
        /// <param name="control"><see cref="Control"/> 实例</param>
        /// <param name="text">文本</param>
        /// <param name="nullText">文本为 <see langword="null"/> 时显示的默认文本</param>
        public static void SetText(this Control control, string text, string nullText)
        {
            control.Text = text ?? nullText;
            control.Enabled = text != null;
        }
    }
}
