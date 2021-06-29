using Sunny.UI;
using System;
using System.IO;

namespace SeewoHelper
{
    public static class Configurations
    {
        /// <summary>
        /// <see cref="SeewoHelper.FileSorterConfig"/> 配置
        /// </summary>
        public static readonly Configuration<FileSorterConfig> FileSorterConfig = new(Path.Combine(Constants.ConfigurationPath, "FileSorterConfig.json"), new(ExtraFileSortingWay.None, Array.Empty<FileSortingInfo>()));

        /// <summary>
        /// <see cref="SeewoHelper.UISettings"/> 配置
        /// </summary>
        public static readonly Configuration<UISettings> UISettings = new(Path.Combine(Constants.ConfigurationPath, "UISettings.json"), new UISettings(UIStyle.LightBlue, LogLevel.Info, false, false, true));
    }
}
