using SeewoHelper.Utilities;
using System.Windows.Forms;

namespace SeewoHelper
{
    internal static class Configurations
    {
        private static readonly string _path = IOUtilities.PathAppend(Application.StartupPath, "Configs");

        public static Configuration<CoursewareSortingInfo> CoursewareSortingInfoConfig = Program.DisposableCollection.Add(new Configuration<CoursewareSortingInfo>("CoursewareSortingInfo", _path));
    }
}
