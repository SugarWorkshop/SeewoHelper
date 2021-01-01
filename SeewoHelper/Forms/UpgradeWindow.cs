using System;
using System.Windows.Forms;

namespace SeewoHelper.Forms
{
    public partial class UpgradeWindow : Form
    {
        public UpgradeWindow()
        {
            InitializeComponent();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void UpgradeWindow_Load(object sender, EventArgs e)
        {
            Program.Logger.Add("开始加载 UpgradeWindow");
            Program.Logger.Add("UpgradeWindow 加载完成");
        }
    }
}
