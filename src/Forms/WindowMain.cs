using SeewoHelper.Features;
using SeewoHelper.Utilities;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeewoHelper.Forms
{
    public partial class WindowMain : UIForm
    {
        private PowerControlTask _powerControlTask;

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

        private async void ButtonStartFileSorting_Click(object sender, EventArgs e)
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
            LoadAutoCheckUpdate();
            LoadHideWhenStart();
            LoadHideToNotify();
            LoadDoubleClickNotify();
            LoadQuicklyControlTimer();
            checkBoxAutoStart.Checked = AutoStartUtilities.IsAutoStart();
            Program.Logger.Info($"{nameof(WindowMain)} 加载完成");
        }

        private void LoadQuicklyControlTimer()
        {
            timerQuicklyControl.Enabled = true;
            timerQuicklyControl.Interval = 1;
            timerQuicklyControl.Stop();
        }

        private void LoadComboBoxExtraFileSortingWay()
        {
            comboBoxExtraFileSortingWay.Items.AddRange(_extraFileSortingWayDictionary.Values.ToArray());
            comboBoxExtraFileSortingWay.SelectedItem = _extraFileSortingWayDictionary[Configurations.FileSorterConfig.Content.ExtraFileSortingWay];
        }

        private void LoadHideWhenStart()
        {
            bool isHideWhenStart = Configurations.UISettings.Content.IsHideWhenStart;
            checkBoxHideWhenStart.Checked = isHideWhenStart;
            if (isHideWhenStart)
            {
                HideWindow();
            }
        }

        private void LoadDoubleClickNotify()
        {
            checkBoxDoubleClickNotify.Checked = Configurations.UISettings.Content.IsDoubleClickNotify;
        }

        private void LoadHideToNotify()
        {
            checkBoxHideToNotify.Checked = Configurations.UISettings.Content.IsHideToNotify;
        }

        private async void LoadAutoCheckUpdate()
        {
            bool isAutoCheckUpdate = Configurations.UISettings.Content.IsAutoCheckUpdate;
            checkBoxAutoCheckUpdate.Checked = isAutoCheckUpdate;
            if (isAutoCheckUpdate)
            {
                await Task.Delay(1000);
                new UpdateCheckerWindow().Show();
            }
        }

        private void CreateServiceCheckBox()
        {
            checkBoxDisableServiceShellHardwareDetection.Tag = new ServiceCheckBox(checkBoxDisableServiceShellHardwareDetection, "ShellHWDetection", true) { PreAction = () => Cursor = Cursors.WaitCursor, PostAction = () => Cursor = Cursors.Default };
            checkBoxDisableServiceWindowsUpdate.Tag = new ServiceCheckBox(checkBoxDisableServiceWindowsUpdate, "wuauserv", true) { PreAction = () => Cursor = Cursors.WaitCursor, PostAction = () => Cursor = Cursors.Default };
            checkBoxDisableServiceWindowsSearch.Tag = new ServiceCheckBox(checkBoxDisableServiceWindowsSearch, "WSearch", true) { PreAction = () => Cursor = Cursors.WaitCursor, PostAction = () => Cursor = Cursors.Default };
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
            if (checkBoxHideToNotify.Checked && e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                HideWindow();
            }
        }

        private void UpdateSubjectStorageInfoConfig()
        {
            var infos = listViewFileSortingInfos.Items.Cast<ListViewItem>().Select(x => (FileSortingInfo)x.Tag);
            Configurations.FileSorterConfig.Content = Configurations.FileSorterConfig.Content with { FileSortingInfos = infos.ToArray() };
            Configurations.FileSorterConfig.Save();
        }

        private void LoadSubjectStorageInfoConfig()
        {
            var info = Configurations.FileSorterConfig.Content;

            foreach (var subject in info.FileSortingInfos)
            {
                AddSubjectStorageInfoToList(subject);
            }
        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (checkBoxDoubleClickNotify.Checked)
            {
                ShowWindow();
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowWindow();
        }

        private async void ShowWindow()
        {
            this.Visible = true;
            await Task.Delay(150);
            WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            Activate();
        }

        private async void HideWindow()
        {
            WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            await Task.Delay(500);
            this.Visible = false;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void CheckBoxAutoCheckUpdate_ValueChanged(object sender, bool value)
        {
            Configurations.UISettings.Content = Configurations.UISettings.Content with { IsAutoCheckUpdate = checkBoxAutoCheckUpdate.Checked };
            Configurations.UISettings.Save();
        }

        private void CheckBoxHideWhenStart_ValueChanged(object sender, bool value)
        {
            Configurations.UISettings.Content = Configurations.UISettings.Content with { IsHideWhenStart = checkBoxHideWhenStart.Checked };
            Configurations.UISettings.Save();
        }

        private void LinkLabelGithub_Click(object sender, EventArgs e)
        {
            NetUtilities.Start(Constants.RepositoryLink);
        }

        private void TabPageAbout_Paint(object sender, PaintEventArgs e)
        {
            labelVersion.Text = "应用版本：" + Constants.Version.ToString(3);
        }

        private void LinkLabelMoInkGithub_Click(object sender, EventArgs e)
        {
            NetUtilities.Start(Constants.MoInkLink);
        }

        private void LinkLabelRickyGithub_Click(object sender, EventArgs e)
        {
            NetUtilities.Start(Constants.RickyLink);
        }

        private void CheckBoxDoubleClickNotify_CheckedChanged(object sender, EventArgs e)
        {
            Configurations.UISettings.Content = Configurations.UISettings.Content with { IsDoubleClickNotify = checkBoxDoubleClickNotify.Checked };
            Configurations.UISettings.Save();
        }

        private void CheckBoxHideToNotify_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxDoubleClickNotify.Enabled = checkBoxHideToNotify.Checked;
            Configurations.UISettings.Content = Configurations.UISettings.Content with { IsHideToNotify = checkBoxHideToNotify.Checked };
            Configurations.UISettings.Save();
        }

        private void ButtonShutdown_Click(object sender, EventArgs e)
        {
            if (_powerControlTask is null)
            {
                _powerControlTask = new PowerControlTask(PowerControlType.Shutdown, TimeSpan.FromSeconds(10)).Start();
                timerQuicklyControl.Start();
            }
        }

        private void ButtonRestart_Click(object sender, EventArgs e)
        {
            if (_powerControlTask is null)
            {
                _powerControlTask = new PowerControlTask(PowerControlType.Reboot, TimeSpan.FromSeconds(10)).Start();
                timerQuicklyControl.Start();
            }
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            if (_powerControlTask is null)
            {
                _powerControlTask = new PowerControlTask(PowerControlType.Logout, TimeSpan.FromSeconds(10)).Start();
                timerQuicklyControl.Start();
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            if (_powerControlTask is not null)
            {
                _powerControlTask.Cancel();
                _powerControlTask = null;

                timerQuicklyControl.Stop();

                processBarQuicklyControl.Value = 0;
                processBarQuicklyControl.Text = "0.0%";
            }
        }

        private void TimerQuicklyControl_Tick(object sender, EventArgs e)
        {
            if (_powerControlTask is null)
            {
                return;
            }

            double result = _powerControlTask.Elapsed / _powerControlTask.Delay * 100;

            processBarQuicklyControl.Value = (int)(result * 10);
            processBarQuicklyControl.Text = $"{result:f1}%";
        }
    }
}