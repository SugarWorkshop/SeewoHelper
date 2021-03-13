using SeewoHelper.Features;
using Sunny.UI;
using System;
using System.Windows.Forms;

namespace SeewoHelper.Forms
{
    public partial class UpdateCheckerWindow : UIForm
    {
        private readonly Updater _updater = new Updater();
        private bool isChecking = false;

        public UpdateCheckerWindow()
        {
            InitializeComponent();
            Program.FormStyleController.Initialize(this);
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpgradeWindow_Load(object sender, EventArgs e)
        {
            Program.Logger.Info("开始加载 UpdateCheckerWindow");

            CheckUpdate();

            Program.Logger.Info("UpdateCheckerWindow 加载完成");
        }

        private void LinkLabelRelease_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ReleaseAssetDownloadingWindow(_updater.Release).ShowDialog();
        }

        private void LinkLabelPreRelease_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ReleaseAssetDownloadingWindow(_updater.Prerelease).ShowDialog();
        }

        private void ButtonCheckAgain_Click(object sender, EventArgs e)
        {
            if (!isChecking)
            {
                CheckUpdate();
            }
        }

        private async void CheckUpdate()
        {
            isChecking = true;
            linkLabelPrerelease.SetText(null, "检测中……");
            linkLabelRelease.SetText(null, "检测中……");
            await _updater.GetInfo();
            linkLabelPrerelease.SetText(_updater.Prerelease?.Name, "暂无");
            linkLabelRelease.SetText(_updater.Release?.Name, "暂无");
            isChecking = false;
        }
    }
}
