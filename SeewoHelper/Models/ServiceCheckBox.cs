using SeewoHelper.Utilities;
using System;
using System.Windows.Forms;

namespace SeewoHelper
{
    public class ServiceCheckBox
    {
        private CheckBox _checkBox;

        private string _serviceName;

        private bool _isReverseCheck;

        public Action StartAction { get; set; }

        public Action StopAction { get; set; }

        private void SetService(bool enable)
        {
            if (enable)
            {
                ServiceUtilities.StartService(_serviceName);
                StartAction.Invoke();
            }
            else
            {
                ServiceUtilities.StopService(_serviceName);
                StopAction.Invoke();
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _checkBox.Invoke(new MethodInvoker(() => SetService(!(_isReverseCheck && _checkBox.Checked))));
        }

        public ServiceCheckBox(CheckBox checkBox, string serviceName, bool isReverseCheck)
        {
            _checkBox = checkBox;
            _serviceName = serviceName;
            _isReverseCheck = isReverseCheck;

            checkBox.Checked = !(isReverseCheck && ServiceUtilities.IsServiceStart(serviceName));
            checkBox.CheckedChanged += CheckBox_CheckedChanged;
        }
    }
}
