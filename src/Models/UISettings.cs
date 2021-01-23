using Sunny.UI;
using System.Text.Json.Serialization;

namespace SeewoHelper
{
    public class UISettings
    {
        public static UISettings Default => new UISettings();

        [JsonPropertyName("style")]
        public UIStyle Style { get; set; } = UIStyle.LightBlue;

        private UISettings()
        {
        }

        [JsonConstructor]
        public UISettings(UIStyle style)
        {
            Style = style;
        }
    }
}
