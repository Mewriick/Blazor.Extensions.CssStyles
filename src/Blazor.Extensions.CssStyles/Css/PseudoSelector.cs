namespace Blazor.Extensions.CssStyles.Css
{
    public class PseudoSelector
    {
        public static PseudoSelector Hover = new PseudoSelector("Hover", "hover");
        public static PseudoSelector Active = new PseudoSelector("Active", "active");
        public static PseudoSelector Checked = new PseudoSelector("Checked", "checked");
        public static PseudoSelector Disabled = new PseudoSelector("Disabled", "disabled");
        public static PseudoSelector Enabled = new PseudoSelector("Enabled", "enabled");
        public static PseudoSelector Focus = new PseudoSelector("Focus", "focus");
        public static PseudoSelector After = new PseudoSelector("After", ":after");
        public static PseudoSelector Before = new PseudoSelector("Before", ":before");

        public string Name { get; }

        public string CssRenderedValue { get; }

        private PseudoSelector(string name, string cssRenderedValue)
        {
            Name = name;
            CssRenderedValue = cssRenderedValue;
        }
    }
}
