namespace Blazor.Extensions.CssStyles.Css
{
    public static class ICssPropertiesExtensions
    {
        public static ICssProperties WithStyle(this ICssProperties cssProperties, string name, string value)
        {
            cssProperties.WithStyle(name, new TextCssStyleValue(value));

            return cssProperties;
        }

        public static ICssProperties WithlStyleInPixelUnit(this ICssProperties cssClass, string styleName, int value)
        {
            cssClass.WithStyle(styleName, new NumberCssStyleValue(value, CssUnits.Px));

            return cssClass;
        }
    }
}
