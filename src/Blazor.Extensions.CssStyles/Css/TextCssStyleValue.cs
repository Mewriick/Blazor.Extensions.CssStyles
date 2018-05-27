using System;
using System.Collections.Generic;

namespace Blazor.Extensions.CssStyles.Css
{
    public class TextCssStyleValue : ValueObject, ICssStyleValue
    {
        private string value;

        public static TextCssStyleValue CreateTextValue(string value) => new TextCssStyleValue(value);

        public TextCssStyleValue(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException(nameof(value));
            }

            this.value = value;
        }

        public string CssRepresentation()
        {
            return value;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return value;
        }
    }
}