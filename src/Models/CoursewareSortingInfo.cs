using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SeewoHelper
{
    /// <summary>
    /// 用于为 <see cref="Features.CoursewareSorter"/> 提供数据
    /// </summary>
    public record CoursewareSortingInfo(string Path, List<SubjectStorageInfo> Subjects);
}
