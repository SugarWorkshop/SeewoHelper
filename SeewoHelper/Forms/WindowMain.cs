using SeewoHelper.Forms;
using SeewoHelper.Utilities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SeewoHelper
{
    public partial class WindowMain : Form
    {
        public WindowMain()
        {
            InitializeComponent();
        }

        private void WindowMain_Load(object sender, EventArgs e)
        {
            ControlUtilities.SetEnabled(
                false,
                textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7,
                button1, button2, button3, button4, button5, button6, button7
                );
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            new AboutWindow().ShowDialog();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            ControlUtilities.SetEnabled(checkBox1.Checked, textBox1, button1);
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            ControlUtilities.SetEnabled(checkBox2.Checked, textBox2, button2);
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            ControlUtilities.SetEnabled(checkBox3.Checked, textBox3, button3);
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            ControlUtilities.SetEnabled(checkBox4.Checked, textBox4, button4);
        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            ControlUtilities.SetEnabled(checkBox5.Checked, textBox5, button5);
        }

        private void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            ControlUtilities.SetEnabled(checkBox6.Checked, textBox6, button6);
        }

        private void CheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            ControlUtilities.SetEnabled(checkBox7.Checked, textBox7, button7);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = FolderBrowserDialogUtilities.GetFilePath();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = FolderBrowserDialogUtilities.GetFilePath();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = FolderBrowserDialogUtilities.GetFilePath();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox4.Text = FolderBrowserDialogUtilities.GetFilePath();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox5.Text = FolderBrowserDialogUtilities.GetFilePath();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            textBox6.Text = FolderBrowserDialogUtilities.GetFilePath();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            textBox7.Text = FolderBrowserDialogUtilities.GetFilePath();
        }

        private void UpgradeMenuItem_Click(object sender, EventArgs e)
        {
            new UpgradeWindow().ShowDialog();
        }
    }
}
