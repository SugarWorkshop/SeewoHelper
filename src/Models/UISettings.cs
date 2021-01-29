using Sunny.UI;
using System.Text.Json.Serialization;

namespace SeewoHelper
{
    /// <summary>
    /// 表示 UI 设置
    /// </summary>
    public class UISettings
    {
        /// <summary>
        /// UI 风格
        /// </summary>
        [JsonPropertyName("style")]
        public UIStyle Style { get; set; } = UIStyle.LightBlue;

        /// <summary>
        /// 创建 <see cref="UISettings"/> 实例
        /// </summary>
        [JsonConstructor]
        public UISettings()
        {
        }
    }
}
