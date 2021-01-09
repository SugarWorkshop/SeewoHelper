using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SeewoHelper
{
    internal static class Configurations
    {
        private static readonly string _path = Path.Combine(Constants.BaseDirectory, "configs");

        /// <summary>
        /// <see cref="CoursewareSortingInfo"/> 配置
        /// </summary>
        public static Configuration<CoursewareSortingInfo> CoursewareSortingInfoConfig = Program.AutoDisposer.AddElement(new Configuration<CoursewareSortingInfo>("CoursewareSortingInfo", _path, new CoursewareSortingInfo(null, new List<SubjectStorageInfo>())));
    }
}
