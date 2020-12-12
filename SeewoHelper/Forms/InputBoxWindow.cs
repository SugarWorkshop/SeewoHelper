﻿using System;
using System.Windows.Forms;

namespace SeewoHelper.Forms
{
    public partial class InputBoxWindow : Form, IReturnableForm<string, string, string, string>
    {
        private string _str = null;

        public InputBoxWindow()
        {
            InitializeComponent();
        }

        public string GetInfo(string prompt, string title = "", string defaultText = "")
        {
            Text = title;
            lblPrompt.Text = prompt;
            textBox.Text = defaultText;
            ShowDialog();

            return _str;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Exit()
        {
            _str = textBox.Text;
            Close();
        }
    }
}
