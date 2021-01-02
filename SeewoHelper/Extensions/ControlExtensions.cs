using System.Windows.Forms;

namespace SeewoHelper
{
    internal static class ControlExtensions
    {
        public static void Remove(this ListView.SelectedListViewItemCollection collection)
        {
            foreach (ListViewItem item in collection)
            {
                item.Remove();
            }
        }

        public static void SetText(this LinkLabel linkLabel, string text, string nullText)
        {
            linkLabel.Text = text ?? nullText;
            linkLabel.Enabled = text != null;
        }
    }
}
