using SeewoHelper.Utilities;
using System;
using System.Threading;
using System.Windows.Forms;

namespace SeewoHelper
{
    public class ServiceCheckBox
    {
        private readonly CheckBox _checkBox;

        private readonly string _serviceName;

        private readonly bool _isReverseCheck;

        private readonly int _startType;

        private void SetService(bool enable)
        {
            if (enable)
            {
                ServiceUtilities.ChangeServiceStartType(_serviceName, _startType);
                ServiceUtilities.StartService(_serviceName);
            }
            else
            {
                ServiceUtilities.StopService(_serviceName);
                ServiceUtilities.ChangeServiceStartType(_serviceName, 4);
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool checkBoxStatus = _isReverseCheck && _checkBox.Checked;

            if (checkBoxStatus == ServiceUtilities.IsServiceStart(_serviceName))
            {
                _checkBox.Enabled = false;

                new Thread(new ThreadStart(() => {
                    SetService(!checkBoxStatus);
                    _checkBox.Invoke(new MethodInvoker(() => _checkBox.Enabled = true));
                })).Start();
            }
        }

        public ServiceCheckBox(CheckBox checkBox, string serviceName, bool isReverseCheck, int startType = 2)
        {
            _checkBox = checkBox ?? throw new ArgumentNullException(nameof(checkBox));
            _serviceName = serviceName ?? throw new ArgumentNullException(nameof(serviceName));
            _isReverseCheck = isReverseCheck;
            _startType = startType;

            checkBox.Checked = !(isReverseCheck && ServiceUtilities.IsServiceStart(serviceName));
            checkBox.CheckedChanged += CheckBox_CheckedChanged;
        }
    }
}
