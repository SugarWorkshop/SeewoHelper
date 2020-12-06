using System.Collections.Generic;

namespace SeewoHelper
{
    public class SubjectStorageInfo
    {
        public string Name { get; }

        public string Path { get; }

        public List<string> Keywords { get; }

        public SubjectStorageInfo(string name, string path, List<string> keywords)
        {
            Name = name;
            Path = path;
            Keywords = keywords;
        }
    }
}
