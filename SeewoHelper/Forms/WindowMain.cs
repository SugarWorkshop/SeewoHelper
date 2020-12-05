using SeewoHelper.Forms;
using System;
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
            textBox1.Enabled = false;
            button1.Enabled = false;
            textBox2.Enabled = false;
            button2.Enabled = false;
            textBox3.Enabled = false;
            button3.Enabled = false;
            textBox4.Enabled = false;
            button4.Enabled = false;
            textBox5.Enabled = false;
            button5.Enabled = false;
            textBox6.Enabled = false;
            button6.Enabled = false;
            textBox7.Enabled = false;
            button7.Enabled = false;
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            new AboutWindow().Show();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                textBox1.Enabled = false;
                button1.Enabled = false;
            }
            else
            {
                textBox1.Enabled = true;
                button1.Enabled = true;
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                textBox2.Enabled = false;
                button2.Enabled = false;
            }
            else
            {
                textBox2.Enabled = true;
                button2.Enabled = true;
            }
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == false)
            {
                textBox3.Enabled = false;
                button3.Enabled = false;
            }
            else
            {
                textBox3.Enabled = true;
                button3.Enabled = true;
            }
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == false)
            {
                textBox4.Enabled = false;
                button4.Enabled = false;
            }
            else
            {
                textBox4.Enabled = true;
                button4.Enabled = true;
            }
        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == false)
            {
                textBox5.Enabled = false;
                button5.Enabled = false;
            }
            else
            {
                textBox5.Enabled = true;
                button5.Enabled = true;
            }
        }

        private void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == false)
            {
                textBox6.Enabled = false;
                button6.Enabled = false;
            }
            else
            {
                textBox6.Enabled = true;
                button6.Enabled = true;
            }
        }

        private void CheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == false)
            {
                textBox7.Enabled = false;
                button7.Enabled = false;
            }
            else
            {
                textBox7.Enabled = true;
                button7.Enabled = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dilog = new FolderBrowserDialog();
            dilog.Description = "请选择文件夹";
            if (dilog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dilog.SelectedPath;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dilog = new FolderBrowserDialog();
            dilog.Description = "请选择文件夹";
            if (dilog.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = dilog.SelectedPath;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dilog = new FolderBrowserDialog();
            dilog.Description = "请选择文件夹";
            if (dilog.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = dilog.SelectedPath;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dilog = new FolderBrowserDialog();
            dilog.Description = "请选择文件夹";
            if (dilog.ShowDialog() == DialogResult.OK)
            {
                textBox4.Text = dilog.SelectedPath;
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dilog = new FolderBrowserDialog();
            dilog.Description = "请选择文件夹";
            if (dilog.ShowDialog() == DialogResult.OK)
            {
                textBox5.Text = dilog.SelectedPath;
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dilog = new FolderBrowserDialog();
            dilog.Description = "请选择文件夹";
            if (dilog.ShowDialog() == DialogResult.OK)
            {
                textBox6.Text = dilog.SelectedPath;
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dilog = new FolderBrowserDialog();
            dilog.Description = "请选择文件夹";
            if (dilog.ShowDialog() == DialogResult.OK)
            {
                textBox7.Text = dilog.SelectedPath;
            }
        }

        private void UpgradeMenuItem_Click(object sender, EventArgs e)
        {
            new UpgradeWindow().Show();
        }
    }
}
