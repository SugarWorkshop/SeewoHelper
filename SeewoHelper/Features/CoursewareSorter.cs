using SeewoHelper.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SeewoHelper.Features
{
    public class CoursewareSorter
    {
        private IEnumerable<SubjectStorageInfo> _subjectStorageInfos;

        private IEnumerable<FileInfo> _files;

        public void Sort()
        {
            foreach (var info in _subjectStorageInfos)
            {
                Sort(info);
            }
        }

        private void Sort(SubjectStorageInfo info)
        {
            var files = new List<FileInfo>();

            foreach (string keyword in info.Keywords)
            {
                files.AddRange(_files.Where(x => new Regex(keyword).IsMatch(x.Name)));
            }

            var processFiles = files.Distinct();

            foreach (var file in processFiles)
            {
                file.MoveTo(IOUtilities.PathAppend(info.Path, file.Name));
            }
        }

        public CoursewareSorter(IEnumerable<SubjectStorageInfo> infos, string path)
        {
            _subjectStorageInfos = infos;
            _files = Directory.GetFiles(path).Select(x => new FileInfo(x));
        }
    }
}
