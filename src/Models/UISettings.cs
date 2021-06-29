using Sunny.UI;

namespace SeewoHelper
{
    /// <summary>
    /// 表示 UI 设置
    /// </summary>
    public record UISettings(UIStyle Style, LogLevel LogLevel, bool IsHideWhenStart, bool IsAutoCheckUpdate, bool IsDoubleClickNotify, bool IsHideToNotify);
}
