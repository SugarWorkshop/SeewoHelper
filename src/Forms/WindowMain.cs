using SeewoHelper.Features;
using SeewoHelper.Utilities;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SeewoHelper.Forms
{
    public partial class WindowMain : UIForm
    {
        private static readonly Dictionary<ExtraFileSortingWay, string> _extraFileSortingWayDictionary = new()
        {
            [ExtraFileSortingWay.None] = "不进行操作",
            [ExtraFileSortingWay.Delete] = "删除"
        };

        public WindowMain()
        {
            InitializeComponent();
            Program.FormStyleController.Initialize(this);
        }

        private void ButtonSubjectInfoRemove_Click(object sender, EventArgs e)
        {
            listViewFileSortingInfos.SelectedItems.Remove();
            UpdateSubjectStorageInfoConfig();
        }

        private void ButtonSubjectStorageInfoAdd_Click(object sender, EventArgs e)
        {
            var info = new FileSortingInfoGettingWindow().GetResult();

            if (info != null)
            {
                AddSubjectStorageInfoToList(info);
            }
        }

        private void AddSubjectStorageInfoToList(FileSortingInfo info)
        {
            var item = new ListViewItem(new string[] { info.Name, info.Path, string.Join(", ", info.Keywords.Select(x => x.Pattern)) }) { Tag = info };
            listViewFileSortingInfos.Items.Add(item);
            UpdateSubjectStorageInfoConfig();
        }

        private void ListViewSubjectStorageInfos_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listViewFileSortingInfos.Columns[e.ColumnIndex].Width;
        }

        private async void ButtonStartCoursewareSorting_Click(object sender, EventArgs e)
        {
            var infos = listViewFileSortingInfos.Items.Cast<ListViewItem>().Select(x => (FileSortingInfo)x.Tag);

            foreach (var info in infos)
            {
                Directory.CreateDirectory(info.Path);
            }

            var sorter = new FileSorter(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), infos);
            await sorter.SortMore();

            await sorter.SortExtraFiles(_extraFileSortingWayDictionary.GetKey((string)comboBoxExtraFileSortingWay.SelectedItem));

            MessageBoxUtilities.ShowSuccess("已完成！");
        }

        private void WindowMain_Load(object sender, EventArgs e)
        {
            Program.Logger.Info($"开始加载 {nameof(WindowMain)}");
            LoadSubjectStorageInfoConfig();
            LoadLoggerConfig();
            CreateServiceCheckBox();
            LoadComboBoxStyle();
            LoadComboBoxExtraFileSortingWay();
            LoadComboBoxLogLevel();
            checkBoxAutoStart.Checked = AutoStartUtilities.IsAutoStart();
            Program.Logger.Info($"{nameof(WindowMain)} 加载完成");
        }

        private void LoadComboBoxExtraFileSortingWay()
        {
            comboBoxExtraFileSortingWay.Items.AddRange(_extraFileSortingWayDictionary.Values.ToArray());
            comboBoxExtraFileSortingWay.SelectedItem = _extraFileSortingWayDictionary[Configurations.FileSortingInfos.Content.ExtraFileSortingWay];
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

        private void LoadComboBoxLogLevel()
        {
            comboBoxLogLevel.Items.AddRange(Enum.GetValues<LogLevel>().Cast<object>().ToArray());
            comboBoxLogLevel.SelectedItem = Configurations.UISettings.Content.LogLevel;
        }

        private void LoadLoggerConfig()
        {
            UpdateLoggerElement();
            Program.Logger.CollectionChanged += (sender, e) => UpdateLoggerElement();
        }

        private void UpdateLoggerElement()
        {
            textBoxLogs.Invoke(new MethodInvoker(() => textBoxLogs.Text = Program.Logger.ToString(Configurations.UISettings.Content.LogLevel)));
        }

        private void ListViewSubjectStorageInfos_DoubleClick(object sender, EventArgs e)
        {
            var selectedItem = listViewFileSortingInfos.SelectedItems.Cast<ListViewItem>().SingleOrDefault();

            if (selectedItem != null)
            {
                var info = new FileSortingInfoGettingWindow().GetResult((FileSortingInfo)selectedItem.Tag);

                if (info != null)
                {
                    var item = new ListViewItem(new string[] { info.Name, info.Path, string.Join(", ", info.Keywords.Select(x => x.Pattern)) }) { Tag = info };
                    listViewFileSortingInfos.Items[selectedItem.Index] = item;
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
            var infos = listViewFileSortingInfos.Items.Cast<ListViewItem>().Select(x => (FileSortingInfo)x.Tag);
            Configurations.FileSortingInfos.Content = Configurations.FileSortingInfos.Content with { FileSortingInfos = infos.ToArray() };
            Configurations.FileSortingInfos.Save();
        }

        private void LoadSubjectStorageInfoConfig()
        {
            var info = Configurations.FileSortingInfos.Content;

            foreach (var subject in info.FileSortingInfos)
            {
                AddSubjectStorageInfoToList(subject);
            }
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
            new AboutWindow().Show();
        }

        private void ToolStripMenuItemUpdateCheckerShow_Click(object sender, EventArgs e)
        {
            new UpdateCheckerWindow().Show();
        }

        private void ComboBoxStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            var style = (UIStyle)comboBoxStyle.SelectedItem;
            Program.FormStyleController.SetStyle(style);
            Configurations.UISettings.Content = Configurations.UISettings.Content with { Style = style };
            Configurations.UISettings.Save();
        }

        private void CheckBoxAutoStart_ValueChanged(object sender, bool value)
        {
            AutoStartUtilities.SetMeStart(checkBoxAutoStart.Checked);
        }

        private void ButtonCleanLog_Click(object sender, EventArgs e)
        {
            foreach (var file in Directory.GetFiles(Constants.LogPath).Where(x => x != Program.Logger.Path))
            {
                File.Delete(file);
            }
        }

        private void ComboBoxLogLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Configurations.UISettings.Content = Configurations.UISettings.Content with { LogLevel = (LogLevel)comboBoxLogLevel.SelectedItem };
            Configurations.UISettings.Save();
            UpdateLoggerElement();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == NativeMethods.WM_SHOWME)
            {
                ShowWindow();
            }
            
            base.WndProc(ref m);
        }
    }
}