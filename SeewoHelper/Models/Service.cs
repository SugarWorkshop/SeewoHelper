using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ServiceProcess;
using System.Threading;

namespace SeewoHelper
{
    public class Service
    {
        public string Name { get; }

        public bool Exists => IsExists();

        public bool Started => IsStarted();

        public ServiceStartMode StartMode => _controller.StartType;

        private readonly ServiceController _controller;

        private static readonly Dictionary<ServiceStartMode, string> _serviceStartModeDictionary = new Dictionary<ServiceStartMode, string>()
        {
            [ServiceStartMode.Boot] = "boot",
            [ServiceStartMode.System] = "system",
            [ServiceStartMode.Automatic] = "auto",
            [ServiceStartMode.Manual] = "demand",
            [ServiceStartMode.Disabled] = "disabled"
        };

        private bool IsExists()
        {
            foreach (ServiceController _controller in ServiceController.GetServices())
            {
                if (_controller.ServiceName.ToLower() == Name.ToLower())
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsStarted()
        {
            bool bStartStatus = false;
            try
            {
                if (!_controller.Status.Equals(ServiceControllerStatus.Stopped))
                {
                    bStartStatus = true;
                }

                return bStartStatus;
            }
            catch
            {
                throw;
            }
        }

        public bool Start()
        {
            bool flag = true;

            if (Exists)
            {
                if (_controller.Status != ServiceControllerStatus.Running && _controller.Status != ServiceControllerStatus.StartPending)
                {
                    _controller.Start();
                    for (int i = 0; i < 60; i++)
                    {
                        _controller.Refresh();
                        Thread.Sleep(1000);
                        if (_controller.Status == ServiceControllerStatus.Running)
                        {
                            break;
                        }
                        if (i == 59)
                        {
                            flag = false;
                        }
                    }
                }
            }

            Program.Logger.Add(new Log($"启动 {Name} 服务"));
            return flag;
        }

        public bool Stop()
        {
            bool flag = true;

            if (Exists)
            {
                if (_controller.Status == ServiceControllerStatus.Running)
                {
                    _controller.Stop();
                    for (int i = 0; i < 60; i++)
                    {
                        _controller.Refresh();
                        Thread.Sleep(1000);
                        if (_controller.Status == ServiceControllerStatus.Stopped)
                        {
                            break;
                        }
                        if (i == 59)
                        {
                            flag = false;
                        }
                    }
                }
            }

            Program.Logger.Add(new Log($"停止 {Name} 服务"));
            return flag;
        }

        public bool SetStartMode(ServiceStartMode startMode)
        {
            try
            {
                var processStartInfo = new ProcessStartInfo("sc.exe", $"config {Name} start={_serviceStartModeDictionary[startMode]}") { CreateNoWindow = false, WindowStyle = ProcessWindowStyle.Hidden };
                Process.Start(processStartInfo).WaitForExit();
            }
            catch
            {
                return false;
            }

            Program.Logger.Add(new Log($"将 {Name} 服务的 startType 调整为 {startMode}"));
            return true;
        }

        public Service(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            _controller = new ServiceController(name);
        }
    }
}
