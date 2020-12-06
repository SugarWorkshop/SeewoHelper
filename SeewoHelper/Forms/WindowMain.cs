using SeewoHelper.Forms;
using System;
using System.Windows.Forms;

namespace SeewoHelper
{
    public partial class WindowMain : Form
    {
        public WindowMain()
        {
            InitializeComponent();
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            new AboutWindow().ShowDialog();
        }

        private void UpgradeMenuItem_Click(object sender, EventArgs e)
        {
            new UpgradeWindow().ShowDialog();
        }

        private void ButtonSubjectInfoRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewSubjectStorageInfos.SelectedItems)
            {
                listViewSubjectStorageInfos.Items.RemoveAt(item.Index);
            }
        }

        private void ButtonSubjectStorageInfoAdd_Click(object sender, EventArgs e)
        {
            var info = SubjectStorageInfoGettingWindow.GetInfo();

            if (info != null)
            {
                var item = new ListViewItem(new string[] { info.Name, info.Path, string.Join(", ", info.Keywords) });
                listViewSubjectStorageInfos.Items.Add(item);
            }
        }

        private void ListViewSubjectStorageInfos_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listViewSubjectStorageInfos.Columns[e.ColumnIndex].Width;
        }
    }
}
