using SeewoHelper.Features;
using SeewoHelper.Forms;
using SeewoHelper.Utilities;
using System;
using System.IO;
using System.Linq;
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
            listViewSubjectStorageInfos.RemoveSelectedItems();
        }

        private void ButtonSubjectStorageInfoAdd_Click(object sender, EventArgs e)
        {
            var info = new SubjectStorageInfoGettingWindow().GetInfo();

            if (info != null)
            {
                var item = new ListViewItem(new string[] { info.Name, info.Path, string.Join(", ", info.Keywords) }) { Tag = info };
                listViewSubjectStorageInfos.Items.Add(item);
            }
        }

        private void ListViewSubjectStorageInfos_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listViewSubjectStorageInfos.Columns[e.ColumnIndex].Width;
        }

        private void ButtonGettingCoursewareSortingSearchingPath_Click(object sender, EventArgs e)
        {
            textBoxCoursewareSortingSearchingPath.Text = FolderBrowserDialogUtilities.GetFilePath();
        }

        private void ButtonStartCoursewareSorting_Click(object sender, EventArgs e)
        {
            var path = textBoxCoursewareSortingSearchingPath.Text;

            if (IOUtilities.IsProperPath(path) && IOUtilities.GetPathType(path, true) == PathType.Directionary && Directory.Exists(path))
            {
                var infos = listViewSubjectStorageInfos.Items.ToList().Select(x => (SubjectStorageInfo)x.Tag);

                foreach (var info in infos)
                {
                    Directory.CreateDirectory(info.Path);
                }

                var sorter = new CoursewareSorter(infos, textBoxCoursewareSortingSearchingPath.Text);
                sorter.Sort();
            }
            else
            {
                MessageBox.Show("非法路径或指定目录不存在！");
            }
        }
    }
}
