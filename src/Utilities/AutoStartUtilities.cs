using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Linq;

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
        /// <param name="enabled">自启开关</param>
        /// <returns></returns>
        public static void SetMeStart(bool enabled)
        {
            if (enabled)
            {
                Program.Logger.Info("设置开机自启");
            }
            else
            {
                Program.Logger.Info("关闭开机自启");
            }

            var module = Process.GetCurrentProcess().MainModule;
            SetAutoStart(enabled, module.ModuleName, module.FileName);
        }

        /// <summary>
        /// 将应用程序设为或不设为开机启动
        /// </summary>
        /// <param name="enabled">自启开关</param>
        /// <param name="name">应用程序名</param>
        /// <param name="path">应用程序完全路径</param>
        public static void SetAutoStart(bool enabled, string name, string path)
        {
            var key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);

            if (key is null)
            {
                throw new InvalidOperationException();
            }

            // 若开机自启动则添加键值对
            if (enabled)
            {
                key.SetValue(name, path);
                key.Close();
            }
            else // 否则删除键值对
            {
                var keyNames = key.GetValueNames().Where(keyName => keyName.Equals(name, StringComparison.OrdinalIgnoreCase));

                foreach (string keyName in keyNames)
                {
                    key.DeleteValue(name);
                    key.Close();
                }
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
            var runs = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);

            if (runs is null)
            {
                throw new InvalidOperationException();
            }

            return runs.GetValueNames().Any(name => name.Equals(keyName, StringComparison.OrdinalIgnoreCase));
        }
    }
}
