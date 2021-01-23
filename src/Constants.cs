using System;
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
        /// 贡献者
        /// 若有贡献请修改该字段
        /// </summary>
        public static readonly string[] Contributors = new string[] { "Mo_Ink", "ricky8955555" };

        /// <summary>
        /// 项目链接
        /// </summary>
        public static readonly string RepositoryLink = "https://github.com/Mo-Ink/SeewoHelper";

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
    }
}
