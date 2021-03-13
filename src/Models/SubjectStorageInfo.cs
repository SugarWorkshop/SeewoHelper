using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SeewoHelper
{
    /// <summary>
    /// 表示科目存储信息
    /// </summary>
    public record SubjectStorageInfo(string Name, string Path, List<Keyword> Keywords);
}
