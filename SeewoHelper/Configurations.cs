using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows.Forms;

namespace SeewoHelper
{
    internal static class Configurations
    {
        private static readonly string _path = Path.Combine(Application.StartupPath, "Configs");

        public static Configuration<CoursewareSortingInfo> CoursewareSortingInfoConfig = Program.AutoDisposer.AddElement(new Configuration<CoursewareSortingInfo>("CoursewareSortingInfo", _path, new CoursewareSortingInfo(null, new List<SubjectStorageInfo>())));

        public static Configuration<ObservableCollection<Log>> LoggerConfig = Program.AutoDisposer.AddElement(new Configuration<ObservableCollection<Log>>("Logger", _path, new ObservableCollection<Log>()));
    }
}
