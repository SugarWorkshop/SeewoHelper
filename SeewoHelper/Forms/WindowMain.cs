using Console.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
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

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
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

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
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

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
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

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
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

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
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
    }
}
