using SeewoHelper.Features;
using Sunny.UI;
using System;
using System.Windows.Forms;

namespace SeewoHelper.Forms
{
    public partial class UpdateCheckerWindow : UIForm
    {
        private readonly Updater _updater = new Updater();

        public UpdateCheckerWindow()
        {
            InitializeComponent();
            Program.style.OnStyleChange += Style_OnStyleChanged;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void UpgradeWindow_Load(object sender, EventArgs e)
        {
            Program.Logger.Add("开始加载 UpdateCheckerWindow");
            Style = Program.style.ProgramStyle;

            await _updater.GetInfo();

            linkLabelPrerelease.SetText(_updater.Prerelease?.Name, "暂无");
            linkLabelRelease.SetText(_updater.Release?.Name, "暂无");

            Program.Logger.Add("UpdateCheckerWindow 加载完成");
        }

        private void LinkLabelRelease_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new UpdateReleaseChooseWindow(_updater.Release).ShowDialog();
        }

        private void LinkLabelPreRelease_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new UpdateReleaseChooseWindow(_updater.Prerelease).ShowDialog();
        }

        private void Style_OnStyleChanged(object sender, EventArgs e)
        {
            Style = Program.style.ProgramStyle;
        }
    }
}
