using Sunny.UI;
using System.IO;

namespace SeewoHelper
{
    public static class Configurations
    {
        /// <summary>
        /// <see cref="SeewoHelper.CoursewareSortingInfo"/> 配置
        /// </summary>
        public static readonly Configuration<CoursewareSortingInfo> CoursewareSortingInfo = new Configuration<CoursewareSortingInfo>(Path.Combine(Constants.ConfigurationPath, "CoursewareSortingInfo.json"), new CoursewareSortingInfo(string.Empty, new()));

        /// <summary>
        /// <see cref="SeewoHelper.UISettings"/> 配置
        /// </summary>
        public static readonly Configuration<UISettings> UISettings = new Configuration<UISettings>(Path.Combine(Constants.ConfigurationPath, "UISettings.json"), new UISettings(UIStyle.LightBlue, LogLevel.Info));
    }
}
