using System;
using System.ServiceProcess;
using System.Threading;
using System.Windows.Forms;

namespace SeewoHelper
{
    public class ServiceCheckBox
    {
        private readonly CheckBox _checkBox;

        private readonly Service _service;

        private readonly bool _isReverseCheck;

        private readonly ServiceStartMode _startMode;

        public Action PreAction { get; set; }

        public Action PostAction { get; set; }

        private void SetService(bool enable)
        {
            if (enable)
            {
                _service.SetStartMode(_startMode);
                _service.Start();
            }
            else
            {
                _service.Stop();
                _service.SetStartMode(ServiceStartMode.Disabled);
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool checkBoxStatus = _isReverseCheck && _checkBox.Checked;

            if (checkBoxStatus == _service.IsRunning)
            {
                PreAction?.Invoke();
                _checkBox.Enabled = false;

                new Thread(new ThreadStart(() =>
                {
                    try
                    {
                        SetService(!checkBoxStatus);
                    }
                    finally
                    {
                        _checkBox.Invoke(new MethodInvoker(() => _checkBox.Enabled = true));

                        if (PostAction != null)
                        {
                            _checkBox.Invoke(PostAction);
                        }
                    }
                })).Start();
            }
        }

        public ServiceCheckBox(CheckBox checkBox, string serviceName, bool isReverseCheck, ServiceStartMode startMode = ServiceStartMode.Automatic)
        {
            _checkBox = checkBox ?? throw new ArgumentNullException(nameof(checkBox));
            _service = new Service(serviceName ?? throw new ArgumentNullException(nameof(serviceName)));
            _isReverseCheck = isReverseCheck;
            _startMode = startMode;

            checkBox.Checked = !(isReverseCheck && _service.IsRunning);
            checkBox.CheckedChanged += CheckBox_CheckedChanged;
        }
    }
}
