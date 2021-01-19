using Sunny.UI;
using System;

namespace SeewoHelper.Forms
{
    public partial class InputBoxWindow : UIForm, IReturnableForm<string, string, string, string>
    {
        private string _str = null;

        public InputBoxWindow()
        {
            InitializeComponent();
            Program.style.OnStyleChange += Style_OnStyleChanged;
        }

        public string GetResult(string prompt, string title = "", string defaultText = "")
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

        private void InputBoxWindow_Load(object sender, EventArgs e)
        {
            Program.Logger.Add("开始加载 InputBoxWindow");
            Style = Program.style.ProgramStyle;
            Program.Logger.Add("InputBoxWindow 加载完成");
        }

        private void Style_OnStyleChanged(object sender, EventArgs e)
        {
            Style = Program.style.ProgramStyle;
        }
    }
}
