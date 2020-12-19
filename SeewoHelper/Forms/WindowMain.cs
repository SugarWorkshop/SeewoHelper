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
            listViewSubjectStorageInfos.SelectedItems.Remove();
        }

        private void ButtonSubjectStorageInfoAdd_Click(object sender, EventArgs e)
        {
            var info = new SubjectStorageInfoGettingWindow().GetInfo();

            if (info != null)
            {
                AddSubjectStorageInfoToList(info);
            }
        }

        private void AddSubjectStorageInfoToList(SubjectStorageInfo info)
        {
            var item = new ListViewItem(new string[] { info.Name, info.Path, string.Join(", ", info.Keywords) }) { Tag = info };
            listViewSubjectStorageInfos.Items.Add(item);
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
                var infos = listViewSubjectStorageInfos.Items.Cast<ListViewItem>().Select(x => (SubjectStorageInfo)x.Tag);

                if (infos.Any(x => x.Path == path))
                {
                    MessageBox.Show("整理目标目录与搜索目录路径相同！");
                }
                else
                {
                    foreach (var info in infos)
                    {
                        Directory.CreateDirectory(info.Path);
                    }

                    var sorter = new CoursewareSorter(new CoursewareSortingInfo(textBoxCoursewareSortingSearchingPath.Text, infos.ToList()));
                    sorter.Sort();

                    MessageBox.Show("完成！");
                }
            }
            else
            {
                MessageBox.Show("非法路径或指定目录不存在！");
            }
        }

        private void WindowMain_Load(object sender, EventArgs e)
        {
            var info = Configurations.CoursewareSortingInfoConfig.Content;

            if (info != null)
            {
                foreach (var subject in info.Subjects)
                {
                    AddSubjectStorageInfoToList(subject);
                }

                textBoxCoursewareSortingSearchingPath.Text = info.Path;
            }
        }

        private void WindowMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            var infos = listViewSubjectStorageInfos.Items.Cast<ListViewItem>().Select(x => (SubjectStorageInfo)x.Tag);
            Configurations.CoursewareSortingInfoConfig.Content = new CoursewareSortingInfo(textBoxCoursewareSortingSearchingPath.Text, infos.ToList());
        }

        private void ListViewSubjectStorageInfos_DoubleClick(object sender, EventArgs e)
        {
            var selectedItem = listViewSubjectStorageInfos.SelectedItems.Cast<ListViewItem>().SingleOrDefault();

            if (selectedItem != null)
            {
                var info = new SubjectStorageInfoGettingWindow().GetInfo((SubjectStorageInfo)selectedItem.Tag);

                if (info != null)
                {
                    var item = new ListViewItem(new string[] { info.Name, info.Path, string.Join(", ", info.Keywords) }) { Tag = info };
                    listViewSubjectStorageInfos.Items[selectedItem.Index] = item;
                }
            }
        }
    }
}
