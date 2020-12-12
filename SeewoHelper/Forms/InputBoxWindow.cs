using System;
using System.Windows.Forms;

namespace SeewoHelper.Forms
{
    public partial class InputBoxWindow : Form, IReturnableForm<string, string, string>
    {
        private string _str = null;

        public InputBoxWindow()
        {
            InitializeComponent();
        }

        public string GetInfo(string prompt, string title = "")
        {
            Text = title;
            lblPrompt.Text = prompt;
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

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Exit();
            }
        }

        private void Exit()
        {
            _str = textBox.Text;
            Close();
        }
    }
}
