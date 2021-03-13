using System.Collections.Generic;

namespace SeewoHelper
{
    /// <summary>
    /// 表示科目存储信息
    /// </summary>
    public record SubjectStorageInfo(string Name, string Path, List<Keyword> Keywords);
}
