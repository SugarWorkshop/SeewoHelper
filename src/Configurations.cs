using Sunny.UI;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SeewoHelper
{
    public static class Configurations
    {
        /// <summary>
        /// <see cref="SeewoHelper.CoursewareSortingInfo"/> 配置
        /// </summary>
        public static readonly Configuration<IEnumerable<FileSortingInfo>> FileSortingInfos = new Configuration<IEnumerable<FileSortingInfo>>(Path.Combine(Constants.ConfigurationPath, "CoursewareSortingInfo.json"), Enumerable.Empty<FileSortingInfo>());

        /// <summary>
        /// <see cref="SeewoHelper.UISettings"/> 配置
        /// </summary>
        public static readonly Configuration<UISettings> UISettings = new Configuration<UISettings>(Path.Combine(Constants.ConfigurationPath, "UISettings.json"), new UISettings(UIStyle.LightBlue, LogLevel.Info));
    }
}
