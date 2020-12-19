using System.Collections.Generic;
using System.Windows.Forms;

namespace SeewoHelper
{
    internal static class ListViewExtensions
    {
        public static void Remove(this ListView.SelectedListViewItemCollection collection)
        {
            foreach (ListViewItem item in collection)
            {
                item.Remove();
            }
        }
    }
}
