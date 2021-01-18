using SeewoHelper.Utilities;
using Sunny.UI;
using System;

namespace SeewoHelper.Forms
{
    public partial class UpdateReleaseChooseWindow : UIForm
    {
        private ReleaseInfo Release;

        private AssetInfo[] Assets;

        public UpdateReleaseChooseWindow(ReleaseInfo release)
        {
            InitializeComponent();
            Program.style.OnStyleChange += Style_OnStyleChanged;
            Release = release;
            Assets = Release.Assets;
        }

        private void ListBoxRelease_ItemDoubleClick(object sender, System.EventArgs e)
        {
            if (checkBoxFastGit.Checked)
            {
                NetUtilities.Start(Assets[listBoxRelease.SelectedIndex].FastGitUrl);
            }
            else
            {
                NetUtilities.Start(Assets[listBoxRelease.SelectedIndex].Url);
            }
        }

        private void UpdateReleaseChooseWindow_Load(object sender, System.EventArgs e)
        {
            Program.Logger.Add("开始加载 UpdateReleaseChooseWindow");
            Style = Program.style.ProgramStyle;
            labelVersion.Text = "版本：" + Release.Name;
            for (int i = 0; i < Assets.Length; i++)
            {
                listBoxRelease.Items.Add(Assets[i].Name);
            }
            Program.Logger.Add("UpdateReleaseChooseWindow 加载完成");
        }

        private void Style_OnStyleChanged(object sender, EventArgs e)
        {
            Style = Program.style.ProgramStyle;
        }
    }
}
