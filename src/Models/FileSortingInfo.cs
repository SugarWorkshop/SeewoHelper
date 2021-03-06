using System.Collections.Generic;

namespace SeewoHelper
{
    /// <summary>
    /// 用于为 <see cref="SeewoHelper.Features.FileSorter"/> 提供数据
    /// </summary>
    public record FileSortingInfo(string Name, string Path, List<Keyword> Keywords);
}
