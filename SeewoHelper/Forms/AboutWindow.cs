using System;
using System.Windows.Forms;

namespace SeewoHelper.Forms
{
    public partial class AboutWindow : Form
    {
        public AboutWindow()
        {
            InitializeComponent();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Mo-Ink/SeewoHelper");
        }

        private void AboutWindow_Load(object sender, EventArgs e)
        {
            Program.Logger.Add(new Log("开始加载AboutWindow"));
            textBoxContributors.Text = string.Join("\r\n", Constants.Contributors);
            labelVersion.Text = "应用版本：" + Constants.Version.ToString();
            Program.Logger.Add(new Log("AboutWindow加载完成"));
        }
    }
}
