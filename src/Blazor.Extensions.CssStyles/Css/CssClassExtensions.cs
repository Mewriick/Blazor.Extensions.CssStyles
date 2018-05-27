namespace Blazor.Extensions.CssStyles.Css
{
    public static class CssClassExtensions
    {
        public static CssClass WithlStyleInPixelUnit(this CssClass cssClass, string styleName, int value)
        {
            cssClass.WithStyle(styleName, value, CssUnits.Px);

            return cssClass;
        }

        public static CssClass WithlStyleInEmUnit(this CssClass cssClass, string styleName, int value)
        {
            cssClass.WithStyle(styleName, value, CssUnits.Em);

            return cssClass;
        }

        public static CssClass WithlStyleInRemUnit(this CssClass cssClass, string styleName, int value)
        {
            cssClass.WithStyle(styleName, value, CssUnits.Rem);

            return cssClass;
        }

        public static CssClass WithStyle(this CssClass cssClass, string styleName, int value, CssUnits unit)
        {
            var numberValue = new NumberCssStyleValue(value, unit);
            if (cssClass is ICssProperties properties)
            {
                properties.WithStyle(styleName, numberValue);
            }

            return cssClass;
        }

        public static CssClass WithStyle(this CssClass cssClass, string styleName, params ICssStyleValue[] cssValues)
        {
            var complexValue = new ComplexCssStyleValue(cssValues);
            if (cssClass is ICssProperties properties)
            {
                properties.WithStyle(styleName, complexValue);
            }

            return cssClass;
        }
    }
}
