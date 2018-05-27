using System;
using System.Collections.Generic;

namespace Blazor.Extensions.CssStyles.Css
{
    public class CssProperties : ValueObject, ICssProperties
    {
        private readonly List<CssStyle> styles;

        public IEnumerable<CssStyle> Styles => styles;

        public CssProperties()
        {
            styles = new List<CssStyle>();
        }

        public ICssProperties WithStyle(string styleName, ICssStyleValue value)
        {
            if (string.IsNullOrWhiteSpace(styleName))
            {
                throw new ArgumentNullException(nameof(styleName));
            }

            if (value is null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            styles.Add(new CssStyle { Name = styleName, Value = value });

            return this;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            foreach (var style in styles)
            {
                yield return style;
            }
        }
    }
}
