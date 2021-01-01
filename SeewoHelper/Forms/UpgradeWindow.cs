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
            Program.Logger.Add(new Log("开始加载UpgradeWindow"));
            Program.Logger.Add(new Log("UpgradeWindow加载完成"));
        }
    }
}
