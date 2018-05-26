using System.Collections.Generic;

namespace Blazor.MaterialUI.Css
{
    public class CssProperties : ValueObject, ICssProperties
    {
        private readonly List<CssStyle> styles;

        public IEnumerable<CssStyle> Styles => styles;

        public CssProperties()
        {
            styles = new List<CssStyle>();
        }

        public ICssProperties AddStyle(string name, string value)
        {
            styles.Add(new CssStyle { Name = name, Value = value });

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
