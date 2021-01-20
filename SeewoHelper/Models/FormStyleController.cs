using Sunny.UI;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SeewoHelper
{
    public class FormStyleController
    {
        private readonly List<UIForm> _forms = new List<UIForm>();

        private UIStyle? _currentStyle = null;

        public UIStyle CurrentStyle => _currentStyle.Value;

        public void SetStyle(UIStyle style)
        {
            _currentStyle = style;

            foreach (var form in _forms)
            {
                form.Style = style;
            }
        }

        public void Initialize(UIForm form)
        {
            _forms.Add(form);

            _currentStyle ??= form.Style;
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
