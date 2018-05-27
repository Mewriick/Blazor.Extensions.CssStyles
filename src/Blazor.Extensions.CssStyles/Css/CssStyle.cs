using System.Collections.Generic;

namespace Blazor.Extensions.CssStyles.Css
{
    public class CssStyle : ValueObject
    {
        public string Name { get; set; }

        public string Value { get; set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Name;
            yield return Value;
        }
    }
}
