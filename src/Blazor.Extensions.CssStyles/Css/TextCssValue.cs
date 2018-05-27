using System.Collections.Generic;

namespace Blazor.Extensions.CssStyles.Css
{
    public class TextCssValue : ValueObject, ICssValue
    {
        private string value;

        public TextCssValue(string value)
        {
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
