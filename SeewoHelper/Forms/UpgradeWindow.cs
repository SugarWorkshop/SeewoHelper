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
    }
}
