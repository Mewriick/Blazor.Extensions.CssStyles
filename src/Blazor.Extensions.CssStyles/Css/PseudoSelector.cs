using System;

namespace Blazor.Extensions.CssStyles.Css
{
    public class PseudoSelector
    {
        public static PseudoSelector Hover = new PseudoSelector("hover");
        public static PseudoSelector Active = new PseudoSelector("active");
        public static PseudoSelector Checked = new PseudoSelector("checked");
        public static PseudoSelector Disabled = new PseudoSelector("disabled");
        public static PseudoSelector Enabled = new PseudoSelector("enabled");
        public static PseudoSelector Focus = new PseudoSelector("focus");
        public static PseudoSelector After = new PseudoSelector(":after");
        public static PseudoSelector Before = new PseudoSelector(":before");

        public string CssRenderedValue { get; }

        private PseudoSelector(string cssRenderedValue)
        {
            if (string.IsNullOrWhiteSpace(cssRenderedValue))
            {
                throw new ArgumentNullException(nameof(cssRenderedValue));
            }

            CssRenderedValue = cssRenderedValue;
        }
    }
}
