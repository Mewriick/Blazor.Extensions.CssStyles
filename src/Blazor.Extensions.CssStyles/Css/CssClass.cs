using System;
using System.Collections.Generic;

namespace Blazor.Extensions.CssStyles.Css
{
    public class CssClass : ValueObject, ICssClass
    {
        private string originalName;
        private readonly CssProperties properties;
        private readonly List<CssPattern> patterns;

        public string Name { get; internal set; }

        public IEnumerable<CssStyle> Styles => properties.Styles;

        public IEnumerable<CssPattern> Patterns => patterns;

        public SelectorType SelectorType => SelectorType.Class;

        public CssClass(string name)
        {
            originalName = name;
            Name = name;

            properties = new CssProperties();
            patterns = new List<CssPattern>();
        }

        public CssClass WithStyle(string name, string value)
        {
            properties.WithStyle(name, value);

            return this;
        }

        public CssClass AddPseudoSelector(PseudoSelector pseudoSelector, Action<CssProperties> configureStyles)
        {
            var cssSelector = new CssPattern(pseudoSelector.CssRenderedValue);
            configureStyles(cssSelector);

            patterns.Add(cssSelector);

            return this;
        }

        public CssClass AddMediaQuery(string query, Action<CssProperties> configureStyles)
        {
            var cssSelector = new MediaCssPattern(query);
            configureStyles(cssSelector);

            patterns.Add(cssSelector);

            return this;
        }

        public void AssignUniqueName()
        {
            Name = $"{originalName}-{Math.Abs(GetHashCode())}";
        }

        ICssProperties ICssProperties.WithStyle(string name, string value)
        {
            properties.WithStyle(name, value);

            return this;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return originalName;

            foreach (var style in properties.Styles)
            {
                yield return style;
            }

            foreach (var pattern in patterns)
            {
                yield return pattern;
            }
        }
    }
}
