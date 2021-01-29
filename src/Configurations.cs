using System.IO;

namespace SeewoHelper
{
    public static class Configurations
    {
        private static readonly string _path = Path.Combine(Constants.BaseDirectory, "configs");

        /// <summary>
        /// <see cref="SeewoHelper.CoursewareSortingInfo"/> 配置
        /// </summary>
        public static readonly Configuration<CoursewareSortingInfo> CoursewareSortingInfo = new Configuration<CoursewareSortingInfo>(Path.Combine(_path, "CoursewareSortingInfo.json"), new CoursewareSortingInfo());

        /// <summary>
        /// <see cref="SeewoHelper.UISettings"/> 配置
        /// </summary>
        public static readonly Configuration<UISettings> UISettings = new Configuration<UISettings>(Path.Combine(_path, "UISettings.json"), new UISettings());
    }
}
