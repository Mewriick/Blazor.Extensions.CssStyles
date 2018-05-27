using System;
using System.Linq;

namespace Blazor.Extensions.CssStyles.Css
{
    public class ComplexCssStyleValue : ICssStyleValue
    {
        private readonly ICssStyleValue[] cssValues;

        public ComplexCssStyleValue(ICssStyleValue[] cssValues)
        {
            this.cssValues = cssValues ?? throw new ArgumentNullException(nameof(cssValues));
        }

        public string CssRepresentation()
        {
            var cssValueText = string.Join(" ", cssValues.Select(c => c.CssRepresentation()));

            return cssValueText;
        }
    }
}
