using Sunny.UI;
using System;
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
        public static readonly Configuration<FileSorterConfig> FileSortingInfos = new(Path.Combine(Constants.ConfigurationPath, "CoursewareSortingInfo.json"), new(ExtraFileSortingWay.None, Array.Empty<FileSortingInfo>()));

        /// <summary>
        /// <see cref="SeewoHelper.UISettings"/> 配置
        /// </summary>
        public static readonly Configuration<UISettings> UISettings = new(Path.Combine(Constants.ConfigurationPath, "UISettings.json"), new UISettings(UIStyle.LightBlue, LogLevel.Info));
    }
}
