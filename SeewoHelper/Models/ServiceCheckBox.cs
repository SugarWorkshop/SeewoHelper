using SeewoHelper.Forms;
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

        public Action StartAction { get; set; }

        public Action StopAction { get; set; }

        private void SetService(bool enable)
        {
            if (enable)
            {
                StartAction.Invoke();
                ServiceUtilities.StartService(_serviceName);
            }
            else
            {
                ServiceUtilities.StopService(_serviceName);
                StopAction.Invoke();
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool checkBoxStatus = _isReverseCheck && _checkBox.Checked;

            if (checkBoxStatus == ServiceUtilities.IsServiceStart(_serviceName))
            {
                _checkBox.Enabled = false;
                Program.windowMain.Cursor = Cursors.WaitCursor;

                new Thread(new ThreadStart(() => {
                    SetService(!checkBoxStatus);
                    Program.windowMain.Invoke(new MethodInvoker(() => { Program.windowMain.Cursor = Cursors.Default; _checkBox.Enabled = true; }));
                })).Start();
            }
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
