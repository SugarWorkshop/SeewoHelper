using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SeewoHelper
{
    internal static class Configurations
    {
        private static readonly string _path = Path.Combine(Application.StartupPath, "configs");

        public static Configuration<CoursewareSortingInfo> CoursewareSortingInfoConfig = Program.AutoDisposer.AddElement(new Configuration<CoursewareSortingInfo>("CoursewareSortingInfo", _path, new CoursewareSortingInfo(null, new List<SubjectStorageInfo>())));
    }
}
