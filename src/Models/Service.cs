using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ServiceProcess;
using System.Threading.Tasks;

namespace SeewoHelper
{
    /// <summary>
    /// 定义服务
    /// </summary>
    public class Service
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// 是否存在
        /// </summary>
        public bool Exists => _controller.ServiceName.ToLower() == Name.ToLower();

        /// <summary>
        /// 状态
        /// </summary>
        public ServiceControllerStatus Status => Refresh().Status;

        /// <summary>
        /// 启动类型
        /// </summary>
        public ServiceStartMode StartType => Refresh().StartType;

        /// <summary>
        /// 当前 <see cref="Service"/> 实例的 <see cref="ServiceController"/>
        /// </summary>
        private readonly ServiceController _controller;

        /// <summary>
        /// <see cref="ServiceStartMode"/> 对应 <see cref="string"/> 指令词典
        /// </summary>
        private static readonly Dictionary<ServiceStartMode, string> _serviceStartModeDictionary = new Dictionary<ServiceStartMode, string>()
        {
            [ServiceStartMode.Boot] = "boot",
            [ServiceStartMode.System] = "system",
            [ServiceStartMode.Automatic] = "auto",
            [ServiceStartMode.Manual] = "demand",
            [ServiceStartMode.Disabled] = "disabled"
        };

        /// <summary>
        /// 刷新
        /// </summary>
        /// <returns>刷新后的 <see cref="ServiceController"/></returns>
        private ServiceController Refresh()
        {
            _controller.Refresh();
            return _controller;
        }

        /// <summary>
        /// 异步启动
        /// </summary>
        public async Task StartAsync()
        {
            _controller.Start();
            await Task.Run(() => _controller.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromMinutes(1)));

            Program.Logger.Add($"启动 {Name} 服务");
        }

        /// <summary>
        /// 异步停止
        /// </summary>
        public async Task StopAsync()
        {
            _controller.Stop();
            await Task.Run(() => _controller.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromMinutes(1)));

            Program.Logger.Add($"停止 {Name} 服务");
        }

        /// <summary>
        /// 设置启动类型
        /// </summary>
        public async Task SetStartTypeAsync(ServiceStartMode startType)
        {
            var processStartInfo = new ProcessStartInfo("sc.exe", $"config {Name} start= {_serviceStartModeDictionary[startType]}") { CreateNoWindow = false, WindowStyle = ProcessWindowStyle.Hidden };
            await Process.Start(processStartInfo).WaitForExitAsync();

            Program.Logger.Add($"将 {Name} 服务的 StartType 调整为 {startType}");
        }

        /// <summary>
        /// 创建 <see cref="Service"/> 实例
        /// </summary>
        /// <param name="name">名称</param>
        public Service(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            _controller = new ServiceController(name);
        }
    }
}
