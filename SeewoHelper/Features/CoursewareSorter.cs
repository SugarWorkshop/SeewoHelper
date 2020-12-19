using SeewoHelper.Utilities;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace SeewoHelper.Features
{
    public class CoursewareSorter
    {
        private readonly IEnumerable<SubjectStorageInfo> _subjectStorageInfos;

        private readonly DirectoryInfo _directory;

        public void Sort()
        {
            foreach (var info in _subjectStorageInfos)
            {
                Sort(info);
            }
        }

        private void Sort(SubjectStorageInfo info)
        {
            var files = _directory.GetFiles();
            var directories = _directory.GetDirectories();

            var selectedFiles = new List<FileInfo>();
            var selectedDirectories = new List<DirectoryInfo>();

            foreach (string keyword in info.Keywords)
            {
                var regex = new Regex(keyword);

                selectedFiles.AddRange(files.Where(x => regex.IsMatch(x.Name)));
                selectedDirectories.AddRange(directories.Where(x => regex.IsMatch(x.Name)));
            }

            var processFiles = selectedFiles.Distinct();
            var processDirectories = selectedDirectories.Distinct();

            foreach (var file in processFiles)
            {
                file.MoveTo(IOUtilities.PathAppend(info.Path, file.Name), true);
            }

            foreach (var directory in processDirectories)
            {
                directory.MoveTo(IOUtilities.PathAppend(info.Path, directory.Name), true);
            }
        }

        public CoursewareSorter(CoursewareSortingInfo info)
        {
            _subjectStorageInfos = info.Subjects;
            _directory = new DirectoryInfo(info.Path);
        }
    }
}
