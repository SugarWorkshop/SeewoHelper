using SeewoHelper.Utilities;
using Sunny.UI;
using System;
using System.ServiceProcess;
using System.Threading.Tasks;

namespace SeewoHelper
{
    /// <summary>
    /// 定义控制服务开关的 <see cref="UICheckBox"/>
    /// </summary>
    public class ServiceCheckBox
    {
        /// <summary>
        /// <see cref="UICheckBox"/> 实例
        /// </summary>
        private readonly UICheckBox _checkBox;

        /// <summary>
        /// <see cref="Service"/> 实例
        /// </summary>
        private readonly Service _service;

        /// <summary>
        /// 是否反转 <see cref="UICheckBox.Checked"/> 状态
        /// </summary>
        private readonly bool _isReverseChecked;

        /// <summary>
        /// 启用时设置的启动类型
        /// </summary>
        private readonly ServiceStartMode _startType;

        /// <summary>
        /// 当前 <see cref="UICheckBox.Checked"/> 应为的状态
        /// </summary>
        private bool IsChecked => SystemUtilities.ReverseBool(_isReverseChecked, _service.Status == ServiceControllerStatus.Running);

        /// <summary>
        /// 预操作
        /// </summary>
        public Action PreAction { get; set; }

        /// <summary>
        /// 后操作
        /// </summary>
        public Action PostAction { get; set; }

        /// <summary>
        /// 设置服务状态
        /// </summary>
        /// <param name="enable">是否启用</param>
        private async Task SetService(bool enable)
        {
            if (enable)
            {
                await _service.SetStartTypeAsync(_startType);
                await _service.StartAsync();
            }
            else
            {
                await _service.StopAsync();
                await _service.SetStartTypeAsync(ServiceStartMode.Disabled);
            }
        }

        /// <summary>
        /// 当 <see cref="UICheckBox.Checked"/> 状态改变时触发
        /// </summary>
        private async void CheckBox_ValueChanged(object sender, bool value)
        {
            // --- 用于保留当前状态，解决部分问题 ---
            bool current = _service.Status == ServiceControllerStatus.Running;
            bool isChecked = SystemUtilities.ReverseBool(_isReverseChecked, current);
            // --- ! ---

            if (_checkBox.Checked != isChecked)
            {
                PreAction?.Invoke();
                _checkBox.Enabled = false;

                try
                {
                    await SetService(!current);
                }
                catch
                {
                    _checkBox.Checked = IsChecked;
                    throw;
                }
                finally
                {
                    _checkBox.Enabled = true;
                    PostAction?.Invoke();
                }
            }
        }

        /// <summary>
        /// 创建 <see cref="ServiceCheckBox"/> 实例
        /// </summary>
        /// <param name="checkBox"><see cref="UICheckBox"/> 实例</param>
        /// <param name="serviceName">服务名称</param>
        /// <param name="isReverseChecked">是否反转 <see cref="UICheckBox.Checked"/> 状态</param>
        /// <param name="startType">启用时设置的启动类型</param>
        public ServiceCheckBox(UICheckBox checkBox, string serviceName, bool isReverseChecked, ServiceStartMode startType = ServiceStartMode.Automatic)
        {
            _checkBox = checkBox ?? throw new ArgumentNullException(nameof(checkBox));
            _service = new Service(serviceName ?? throw new ArgumentNullException(nameof(serviceName)));
            _isReverseChecked = isReverseChecked;
            _startType = startType;

            checkBox.Checked = IsChecked;
            checkBox.ValueChanged += CheckBox_ValueChanged;
        }
    }
}
