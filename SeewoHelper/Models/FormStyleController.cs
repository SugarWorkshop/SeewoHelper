using Sunny.UI;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SeewoHelper
{
    public class FormStyleController
    {
        private readonly List<UIForm> _forms = new List<UIForm>();

        public UIStyle CurrentStyle { get; private set; }

        public void SetStyle(UIStyle style)
        {
            CurrentStyle = style;

            foreach (var form in _forms)
            {
                form.Style = style;
            }
        }

        public void Initialize(UIForm form)
        {
            _forms.Add(form);
            form.Style = CurrentStyle;
            form.FormClosed += Form_FormClosed;
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            _forms.Remove((UIForm)sender);
        }

        public FormStyleController()
        {
        }
    }
}
