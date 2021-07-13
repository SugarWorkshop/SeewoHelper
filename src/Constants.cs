using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace SeewoHelper
{
    /// <summary>
    /// 用于提供常量
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// 应用名称
        /// </summary>
        public static readonly string AppName = Application.ProductName;

        /// <summary>
        /// 项目链接
        /// </summary>
        public static readonly string RepositoryLink = "https://github.com/Mo-Ink/SeewoHelper";

        /// <summary>
        /// Mo-Ink Github 主页
        /// </summary>
        public static readonly string MoInkLink = "https://github.com/Mo-Ink";

        /// <summary>
        /// Ricky Github 主页
        /// </summary>
        public static readonly string RickyLink = "https://github.com/ricky8955555";

        /// <summary>
        /// 应用版本
        /// </summary>
        public static readonly Version Version = Assembly.GetExecutingAssembly().GetName().Version;

        /// <summary>
        /// Releases API 链接
        /// </summary>
        public static readonly string ReleasesLink = "https://api.github.com/repos/Mo-Ink/SeewoHelper/releases";

        /// <summary>
        /// 应用运行文件夹路径
        /// </summary>
        public static readonly string BaseDirectory = Environment.CurrentDirectory;

        /// <summary>
        /// 日志路径
        /// </summary>
        public static readonly string LogDirectory = Path.Combine(BaseDirectory, "logs");

        /// <summary>
        /// 配置路径
        /// </summary>
        public static readonly string ConfigurationDirectory = Path.Combine(BaseDirectory, "configs");
    }
}
