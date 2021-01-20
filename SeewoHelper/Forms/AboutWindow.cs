using SeewoHelper.Utilities;
using Sunny.UI;
using System;
using System.Windows.Forms;

namespace SeewoHelper.Forms
{
    public partial class AboutWindow : UIForm
    {
        public AboutWindow()
        {
            InitializeComponent();
            Program.FormStyleController.Initialize(this);
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NetUtilities.Start(Constants.RepositoryLink);
        }

        private void AboutWindow_Load(object sender, EventArgs e)
        {
            Program.Logger.Add("开始加载 AboutWindow");
            Style = Program.style.ProgramStyle;
            textBoxContributors.Text = string.Join("\r\n", Constants.Contributors);
            labelVersion.Text = "应用版本：" + Constants.Version.ToString(3);
            Program.Logger.Add("AboutWindow 加载完成");
        }

        private void Style_OnStyleChanged(object sender, EventArgs e)
        {
            Style = Program.style.ProgramStyle;
        }
    }
}
