using System.Windows.Forms;

namespace SeewoHelper.Utilities
{
    internal static class ControlUtilities
    {
        public static void SetEnabled(bool enabled, params Control[] controls)
        {
            foreach (var control in controls)
            {
                control.Enabled = enabled;
            }
        }
    }
}
