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

        public CssClass WithStyle(string styleName, string value)
        {
            properties.WithStyle(styleName, new TextCssStyleValue(value));

            return this;
        }

        public CssClass AddPseudoSelector(PseudoSelector pseudoSelector, Action<CssProperties> configureStyles)
        {
            if (pseudoSelector is null)
            {
                throw new ArgumentNullException(nameof(pseudoSelector));
            }

            if (configureStyles is null)
            {
                throw new ArgumentNullException(nameof(configureStyles));
            }

            var cssSelector = new CssPattern(pseudoSelector.CssRenderedValue);
            configureStyles(cssSelector);

            patterns.Add(cssSelector);

            return this;
        }

        public CssClass AddMediaQuery(string query, Action<CssProperties> configureStyles)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                throw new ArgumentNullException(nameof(query));
            }

            if (configureStyles is null)
            {
                throw new ArgumentNullException(nameof(configureStyles));
            }

            var cssSelector = new MediaCssPattern(query);
            configureStyles(cssSelector);

            patterns.Add(cssSelector);

            return this;
        }

        public void AssignUniqueName()
        {
            Name = $"{originalName}-{Math.Abs(GetHashCode())}";
        }

        ICssProperties ICssProperties.WithStyle(string name, ICssStyleValue value)
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
