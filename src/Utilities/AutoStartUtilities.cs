using Microsoft.Win32;
using System;
using System.Diagnostics;

namespace SeewoHelper.Utilities
{
    /// <summary>
    /// 提供处理开机自动启动相关的方法
    /// </summary>
    public static class AutoStartUtilities
    {
        /// <summary>
        /// 将本程序设为开启自启
        /// </summary>
        /// <param name="enable">自启开关</param>
        /// <returns></returns>
        public static bool SetMeStart(bool enable)
        {
            string appName = Process.GetCurrentProcess().MainModule.ModuleName;
            string appPath = Process.GetCurrentProcess().MainModule.FileName;

            if (enable)
            {
                Program.Logger.Info("设置开机自启");
            }
            else
            {
                Program.Logger.Info("关闭开机自启");
            }

            return SetAutoStart(enable, appName, appPath);
        }

        /// <summary>
        /// 将应用程序设为或不设为开机启动
        /// </summary>
        /// <param name="onOff">自启开关</param>
        /// <param name="appName">应用程序名</param>
        /// <param name="appPath">应用程序完全路径</param>
        public static bool SetAutoStart(bool onOff, string appName, string appPath)
        {
            //如果从没有设为开机启动设置到要设为开机启动
            if (!KeyExists(appName) && onOff)
            {
                return SelfRunning(onOff, appName, @appPath);
            }
            //如果从设为开机启动设置到不要设为开机启动
            else if (KeyExists(appName) && !onOff)
            {
                return SelfRunning(onOff, appName, @appPath);
            }
            else
            {
                //否则直接返回true
                return true;
            }
        }

        /// <summary>
        /// 判断当前程序是否开机自启
        /// </summary>
        public static bool IsAutoStart() => KeyExists(Process.GetCurrentProcess().MainModule.ModuleName);

        /// <summary>
        /// 判断注册键值对是否存在，即是否处于开机启动状态
        /// </summary>
        /// <param name="keyName">键值名</param>
        /// <returns></returns>
        private static bool KeyExists(string keyName)
        {
            try
            {
                bool exists = false;
                var local = Registry.LocalMachine;
                var runs = local.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);

                if (runs == null)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    string[] runsName = runs.GetValueNames();

                    foreach (string strName in runsName)
                    {
                        if (strName.Equals(keyName, StringComparison.InvariantCultureIgnoreCase))
                        {
                            exists = true;
                            return exists;
                        }
                    }

                    return exists;
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 写入或删除注册表键值对,即设为开机启动或开机不启动
        /// </summary>
        /// <param name="isStart">是否开机启动</param>
        /// <param name="exeName">应用程序名</param>
        /// <param name="path">应用程序路径带程序名</param>
        /// <returns></returns>
        private static bool SelfRunning(bool isStart, string exeName, string path)
        {
            try
            {
                var local = Registry.LocalMachine;
                var key = local.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);

                if (key == null)
                {
                    local.CreateSubKey("SOFTWARE//Microsoft//Windows//CurrentVersion//Run");
                }

                //若开机自启动则添加键值对
                if (isStart)
                {
                    key.SetValue(exeName, path);
                    key.Close();
                }
                else//否则删除键值对
                {
                    string[] keyNames = key.GetValueNames();
                    foreach (string keyName in keyNames)
                    {
                        if (keyName.Equals(exeName, StringComparison.InvariantCultureIgnoreCase))
                        {
                            key.DeleteValue(exeName);
                            key.Close();
                        }
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
