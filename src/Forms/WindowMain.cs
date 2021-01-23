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
            Program.FormStyleController.Initialize(this);
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
            UpdateSubjectStorageInfoConfig();
        }

        private void ButtonStartCoursewareSorting_Click(object sender, EventArgs e)
        {
            var path = textBoxCoursewareSortingSearchingPath.Text;

            if (IOUtilities.IsProperPath(path) && IOUtilities.GetPathType(path, true) == PathType.Directionary && Directory.Exists(path))
            {
                var infos = listViewSubjectStorageInfos.Items.Cast<ListViewItem>().Select(x => (SubjectStorageInfo)x.Tag);

                if (infos.Any(x => x.Path == path))
                {
                    MessageBoxUtilities.ShowError("整理目标目录与搜索目录路径相同！");
                }
                else
                {
                    foreach (var info in infos)
                    {
                        Directory.CreateDirectory(info.Path);
                    }

                    var sorter = new CoursewareSorter(new CoursewareSortingInfo(textBoxCoursewareSortingSearchingPath.Text, infos.ToList()));
                    sorter.SortMore();

                    MessageBoxUtilities.ShowSuccess("已完成！");
                }
            }
            else
            {
                MessageBoxUtilities.ShowError("非法路径或指定目录不存在！");
            }
        }

        private void WindowMain_Load(object sender, EventArgs e)
        {
            Program.Logger.Add("开始加载 WindowMain");
            LoadSubjectStorageInfoConfig();
            LoadLoggerConfig();
            CreateServiceCheckBox();
            LoadComboBoxStyle();
            checkBoxAutoStart.Checked = AutoStartUtilities.IsAutoStart();
            Program.Logger.Add("WindowMain 加载完成");
        }

        private void CreateServiceCheckBox()
        {
            checkBoxDisableServiceShellHardwareDetection.Tag = new ServiceCheckBox(checkBoxDisableServiceShellHardwareDetection, "ShellHWDetection", true) { PreAction = () => Cursor = Cursors.WaitCursor, PostAction = () => Cursor = Cursors.Default };
        }

        private void LoadComboBoxStyle()
        {
            comboBoxStyle.Items.AddRange(Enum.GetValues<UIStyle>().SkipWhile(x => x == UIStyle.Custom).Cast<object>().ToArray());
            comboBoxStyle.SelectedItem = Program.FormStyleController.CurrentStyle;
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
            Configurations.CoursewareSortingInfo.Content = new CoursewareSortingInfo(textBoxCoursewareSortingSearchingPath.Text, infos.ToList());
            Configurations.CoursewareSortingInfo.Save();
        }

        private void LoadSubjectStorageInfoConfig()
        {
            var info = Configurations.CoursewareSortingInfo.Content;

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

        private void ToolStripMenuItemShowAbout_Click(object sender, EventArgs e)
        {
            new AboutWindow().ShowDialog();
        }

        private void ToolStripMenuItemUpdateCheckerShow_Click(object sender, EventArgs e)
        {
            new UpdateCheckerWindow().ShowDialog();
        }

        private void ComboBoxStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            var style = (UIStyle)comboBoxStyle.SelectedItem;
            Program.FormStyleController.SetStyle(style);
            Configurations.UISettings.Content.Style = style;
            Configurations.UISettings.Save();
        }

        private void CheckBoxAutoStart_ValueChanged(object sender, bool value)
        {
            AutoStartUtilities.SetMeStart(checkBoxAutoStart.Checked);
        }
    }
}
