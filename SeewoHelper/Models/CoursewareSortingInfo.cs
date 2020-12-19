using Newtonsoft.Json;
using System.Collections.Generic;

namespace SeewoHelper
{
    public class CoursewareSortingInfo
    {
        public CoursewareSortingInfo(string path, List<SubjectStorageInfo> subjects)
        {
            Path = path;
            Subjects = subjects;
        }

        [JsonProperty(PropertyName = "path")]
        public string Path { get; }

        [JsonProperty(PropertyName = "subjects")]
        public List<SubjectStorageInfo> Subjects { get; }
    }
}
