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

        public ICssProperties WithStyle(string name, string value)
        {
            styles.Add(new CssStyle { Name = name, Value = new TextCssValue(value) });

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
