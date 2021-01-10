using SeewoHelper.Features;
using SeewoHelper.Utilities;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SeewoHelper.Forms
{
    public partial class UpdateCheckerWindow : Form
    {
        private readonly Updater _updater = new Updater();

        public UpdateCheckerWindow()
        {
            InitializeComponent();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void UpgradeWindow_Load(object sender, EventArgs e)
        {
            Program.Logger.Add("开始加载 UpgradeWindow");

            await _updater.GetInfo();

            linkLabelPrerelease.SetText(_updater.Prerelease?.Name, "暂无");
            linkLabelRelease.SetText(_updater.Release?.Name, "暂无");

            Program.Logger.Add("UpgradeWindow 加载完成");
        }

        private void LinkLabelRelease_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NetUtilities.Start(_updater.Release?.Url);
        }

        private void LinkLabelPreRelease_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NetUtilities.Start(_updater.Prerelease?.Url);
        }
    }
}
