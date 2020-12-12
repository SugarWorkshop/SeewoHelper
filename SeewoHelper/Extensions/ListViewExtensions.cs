using System.Collections.Generic;
using System.Windows.Forms;

namespace SeewoHelper
{
    internal static class ListViewExtensions
    {
        public static void RemoveSelectedItems(this ListView listView)
        {
            foreach (ListViewItem item in listView.SelectedItems)
            {
                listView.Items.RemoveAt(item.Index);
            }
        }

        public static List<ListViewItem> ToList(this ListView.ListViewItemCollection collection)
        {
            var list = new List<ListViewItem>();

            foreach (ListViewItem item in collection)
            {
                list.Add(item);
            }

            return list;
        }

        public static List<ListViewItem> ToList(this ListView.SelectedListViewItemCollection collection)
        {
            var list = new List<ListViewItem>();

            foreach (ListViewItem item in collection)
            {
                list.Add(item);
            }

            return list;
        }
    }
}
