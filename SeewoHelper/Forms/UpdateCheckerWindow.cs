using SeewoHelper.Features;
using System;
using System.Diagnostics;
using System.Threading;
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

        private void UpgradeWindow_Load(object sender, EventArgs e)
        {
            Program.Logger.Add("开始加载 UpgradeWindow");

            ThreadPool.QueueUserWorkItem(obj =>
            {
                _updater.GetInfo().Wait();

                if (IsHandleCreated)
                {
                    linkLabelPrerelease.Invoke(new MethodInvoker(() => linkLabelPrerelease.SetText(_updater.Prerelease?.Name, "暂无")));
                    linkLabelRelease.Invoke(new MethodInvoker(() => linkLabelRelease.SetText(_updater.Release?.Name, "暂无")));
                }
            });

            Program.Logger.Add("UpgradeWindow 加载完成");
        }

        private void LinkLabelRelease_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(_updater.Release?.Url);
        }

        private void LinkLabelPreRelease_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(_updater.Prerelease?.Url);
        }
    }
}
