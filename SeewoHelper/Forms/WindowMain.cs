using SeewoHelper.Features;
using SeewoHelper.Utilities;
using Sunny.UI;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SeewoHelper.Forms
{
    public partial class WindowMain : UIForm
    {
        public WindowMain()
        {
            InitializeComponent();
            Program.style.OnStyleChange += Style_OnStyleChanged;
        }

        private void ButtonSubjectInfoRemove_Click(object sender, EventArgs e)
        {
            listViewSubjectStorageInfos.SelectedItems.Remove();
            UpdateSubjectStorageInfoConfig();
        }

        private void ButtonSubjectStorageInfoAdd_Click(object sender, EventArgs e)
        {
            var info = new SubjectStorageInfoGettingWindow().GetResult();

            if (info != null)
            {
                AddSubjectStorageInfoToList(info);
            }
        }

        private void AddSubjectStorageInfoToList(SubjectStorageInfo info)
        {
            var item = new ListViewItem(new string[] { info.Name, info.Path, string.Join(", ", info.Keywords.Select(x => x.Pattern)) }) { Tag = info };
            listViewSubjectStorageInfos.Items.Add(item);
            UpdateSubjectStorageInfoConfig();
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
                    sorter.SortMore();

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
            Program.Logger.Add("开始加载 WindowMain");
            LoadSubjectStorageInfoConfig();
            LoadLoggerConfig();
            CreateServiceCheckBox();
            Style = Program.style.ProgramStyle;
            LoadComboBoxStyle();
            Program.Logger.Add("WindowMain 加载完成");
        }

        private void CreateServiceCheckBox()
        {
            checkBoxDisableServiceShellHardwareDetection.Tag = new ServiceCheckBox(checkBoxDisableServiceShellHardwareDetection, "ShellHWDetection", true) { PreAction = () => Cursor = Cursors.WaitCursor, PostAction = () => Cursor = Cursors.Default };
        }

        private void LoadComboBoxStyle()
        {
            foreach (UIStyle style in Enum.GetValues(typeof(UIStyle)))
            {
                if (style != UIStyle.Custom)
                    comboBoxStyle.Items.Add(style);
            }
            comboBoxStyle.SelectedItem = Program.style.ProgramStyle;
        }

        private void LoadLoggerConfig()
        {
            UpdateLoggerElement();
            Program.Logger.CollectionChanged += (sender, e) => UpdateLoggerElement();
        }

        private void UpdateLoggerElement()
        {
            textBoxLogs.Invoke(new MethodInvoker(() => textBoxLogs.Text = Program.Logger.ToString()));
        }

        private void ListViewSubjectStorageInfos_DoubleClick(object sender, EventArgs e)
        {
            var selectedItem = listViewSubjectStorageInfos.SelectedItems.Cast<ListViewItem>().SingleOrDefault();

            if (selectedItem != null)
            {
                var info = new SubjectStorageInfoGettingWindow().GetResult((SubjectStorageInfo)selectedItem.Tag);

                if (info != null)
                {
                    var item = new ListViewItem(new string[] { info.Name, info.Path, string.Join(", ", info.Keywords.Select(x => x.Pattern)) }) { Tag = info };
                    listViewSubjectStorageInfos.Items[selectedItem.Index] = item;
                }
            }
        }

        private void WindowMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                HideWindow();
            }
        }

        private void UpdateSubjectStorageInfoConfig()
        {
            var infos = listViewSubjectStorageInfos.Items.Cast<ListViewItem>().Select(x => (SubjectStorageInfo)x.Tag);
            Configurations.CoursewareSortingInfoConfig.Content = new CoursewareSortingInfo(textBoxCoursewareSortingSearchingPath.Text, infos.ToList());
        }

        private void LoadSubjectStorageInfoConfig()
        {
            var info = Configurations.CoursewareSortingInfoConfig.Content;

            foreach (var subject in info.Subjects)
            {
                AddSubjectStorageInfoToList(subject);
            }

            textBoxCoursewareSortingSearchingPath.Text = info.Path;
        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowWindow();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowWindow();
        }

        private void ShowWindow()
        {
            Show();
            WindowState = FormWindowState.Normal;
            Activate();
        }

        private void HideWindow()
        {
            Hide();
            WindowState = FormWindowState.Minimized;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TextBoxCoursewareSortingSearchingPath_TextChanged(object sender, EventArgs e)
        {
            UpdateSubjectStorageInfoConfig();
        }

        private void ToolStripMenuItemShowAbout_Click(object sender, EventArgs e)
        {
            new AboutWindow().Show();
        }

        private void ToolStripMenuItemUpdateCheckerShow_Click(object sender, EventArgs e)
        {
            new UpdateCheckerWindow().ShowDialog();
        }

        private void ComboBoxStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.style.ProgramStyle = (UIStyle)comboBoxStyle.SelectedItem;
        }

        private void Style_OnStyleChanged(object sender, EventArgs e)
        {
            Style = Program.style.ProgramStyle;
        }
    }
}
