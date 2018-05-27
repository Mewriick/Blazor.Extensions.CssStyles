namespace Blazor.Extensions.CssStyles.Css
{
    public static class CssClassExtensions
    {
        public static CssClass WithPixelStyle(this CssClass cssClass, string styleName, int value)
        {
            cssClass.WithStyle(styleName, value, CssUnits.Px);

            return cssClass;
        }

        public static CssClass WithStyle(this CssClass cssClass, string styleName, int value, CssUnits unit)
        {
            var numberValue = new NumberCssValue(value, unit);
            cssClass.WithStyle(styleName, numberValue.CssRepresentation());

            return cssClass;
        }
    }
}
