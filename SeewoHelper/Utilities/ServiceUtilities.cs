using Microsoft.Win32;
using System.ServiceProcess;


namespace SeewoHelper.Utilities
{
    class ServiceUtilities
    {
        /// <summary>  
        /// 检查Windows服务是否存在  
        /// </summary>  
        /// <param name="NameService">Windows服务显示名称</param>  
        /// <returns>存在返回 true,否则返回 false;</returns>  
        public static bool IsServiceIsExisted(string serviceName)
        {
            ServiceController[] services = ServiceController.GetServices();
            foreach (ServiceController s in services)
            {
                if (s.ServiceName.ToLower() == serviceName.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 判断某个Windows服务是否启动  
        /// </summary>
        /// <param name="serviceName">Windows服务显示名称</param>
        /// <returns>bool</returns>
        public static bool IsServiceStart(string serviceName)
        {
            ServiceController psc = new ServiceController(serviceName);
            bool bStartStatus = false;
            try
            {
                if (!psc.Status.Equals(ServiceControllerStatus.Stopped))
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

        /// <summary>    
        /// 修改服务的启动项 
        /// </summary>    
        /// <param name="startType">2为Automatic,3为Manul,4为Disabled</param>    
        /// <param name="serviceName">Windows服务显示名称</param>    
        /// <returns>bool</returns>    
        public static bool ChangeServiceStartType(string serviceName, int startType)
        {
            try
            {
                RegistryKey regist = Registry.LocalMachine;
                RegistryKey sysReg = regist.OpenSubKey("SYSTEM");
                RegistryKey currentControlSet = sysReg.OpenSubKey("CurrentControlSet");
                RegistryKey services = currentControlSet.OpenSubKey("Services");
                RegistryKey servicesName = services.OpenSubKey(serviceName, true);
                servicesName.SetValue("Start", startType);
            }
            catch
            {
                return false;
            }
            Program.Logger.Add(new Log($"将 {serviceName} 服务的 startType 调整为 {startType}"));
            return true;
        }

        /// <summary>
        /// 启动服务
        /// </summary>
        /// <param name="serviceName">Windows服务显示名称</param>
        /// <returns>bool</returns>
        public static bool StartService(string serviceName)
        {
            bool flag = true;
            if (IsServiceIsExisted(serviceName))
            {
                ServiceController service = new ServiceController(serviceName);
                if (service.Status != ServiceControllerStatus.Running && service.Status != ServiceControllerStatus.StartPending)
                {
                    service.Start();
                    for (int i = 0; i < 60; i++)
                    {
                        service.Refresh();
                        System.Threading.Thread.Sleep(1000);
                        if (service.Status == ServiceControllerStatus.Running)
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
            Program.Logger.Add(new Log($"启动 {serviceName} 服务"));
            return flag;
        }

        /// <summary>
        /// 停止服务
        /// </summary>
        /// <param name="serviceName">Windows服务显示名称</param>
        /// <returns>bool</returns>
        public static bool StopService(string serviceName)
        {
            bool flag = true;
            if (IsServiceIsExisted(serviceName))
            {
                ServiceController service = new ServiceController(serviceName);
                if (service.Status == ServiceControllerStatus.Running)
                {
                    service.Stop();
                    for (int i = 0; i < 60; i++)
                    {
                        service.Refresh();
                        System.Threading.Thread.Sleep(1000);
                        if (service.Status == ServiceControllerStatus.Stopped)
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
            Program.Logger.Add(new Log($"停止 {serviceName} 服务"));
            return flag;
        }
    }
}
