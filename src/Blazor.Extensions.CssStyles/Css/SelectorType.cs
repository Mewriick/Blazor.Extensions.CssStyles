namespace Blazor.Extensions.CssStyles.Css
{
    public class SelectorType
    {
        public static SelectorType Class = new SelectorType("Class", ".");
        public static SelectorType Element = new SelectorType("Element", string.Empty);
        public static SelectorType Attribute = new SelectorType("Attribute", string.Empty);
        public static SelectorType PseudoClass = new SelectorType("PseudoClass", ":");

        public string Name { get; }

        public string CssRenderingSymbol { get; }


        private SelectorType(string name, string cssRenderingSymbol)
        {
            Name = name;
            CssRenderingSymbol = cssRenderingSymbol;
        }
    }
}
