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
            label2.Text = "贡献者：" + string.Join(", ", Constants.Contributors);
            label3.Text = "应用版本：" + Constants.Version.ToString();
        }
    }
}
