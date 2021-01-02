using SeewoHelper.Utilities;
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

        private bool IsChecked => SystemUtilities.ReverseBool(_isReverseCheck, _service.IsRunning);

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
            // --- 用于保留当前状态，解决部分问题 ---
            bool current = _service.IsRunning;
            bool isChecked = SystemUtilities.ReverseBool(_isReverseCheck, current);
            // --- ! ---

            if (_checkBox.Checked != isChecked)
            {
                PreAction?.Invoke();
                _checkBox.Enabled = false;

                ThreadPool.QueueUserWorkItem(obj =>
                {
                    try
                    {
                        SetService(!current);
                    }
                    catch
                    {
                        _checkBox.Invoke(new MethodInvoker(() => _checkBox.Checked = IsChecked));
                        throw;
                    }
                    finally
                    {
                        _checkBox.Invoke(new MethodInvoker(() => _checkBox.Enabled = true));

                        if (PostAction != null)
                        {
                            _checkBox.Invoke(PostAction);
                        }
                    }
                });
            }
        }

        public ServiceCheckBox(CheckBox checkBox, string serviceName, bool isReverseCheck, ServiceStartMode startMode = ServiceStartMode.Automatic)
        {
            _checkBox = checkBox ?? throw new ArgumentNullException(nameof(checkBox));
            _service = new Service(serviceName ?? throw new ArgumentNullException(nameof(serviceName)));
            _isReverseCheck = isReverseCheck;
            _startMode = startMode;

            checkBox.Checked = IsChecked;
            checkBox.CheckedChanged += CheckBox_CheckedChanged;
        }
    }
}
