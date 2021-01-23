using SeewoHelper.Utilities;
using Sunny.UI;
using System;
using System.Linq;

namespace SeewoHelper.Forms
{
    public partial class ReleaseAssetDownloadingWindow : UIForm
    {
        private readonly ReleaseInfo _release;

        public ReleaseAssetDownloadingWindow(ReleaseInfo release)
        {
            InitializeComponent();
            Program.FormStyleController.Initialize(this);
            _release = release;
        }

        private void ListBoxRelease_ItemDoubleClick(object sender, EventArgs e)
        {
            if (checkBoxFastGit.Checked)
            {
                NetUtilities.Start(_release.Assets[listBoxRelease.SelectedIndex].FastGitUrl);
            }
            else
            {
                NetUtilities.Start(_release.Assets[listBoxRelease.SelectedIndex].Url);
            }
        }

        private void UpdateReleaseChooseWindow_Load(object sender, EventArgs e)
        {
            Program.Logger.Add("开始加载 UpdateReleaseChooseWindow");
            labelVersion.Text = "版本：" + _release.Name;
            listBoxRelease.Items.AddRange(_release.Assets.Select(x => x.Name).ToArray());
            Program.Logger.Add("UpdateReleaseChooseWindow 加载完成");
        }
    }
}
