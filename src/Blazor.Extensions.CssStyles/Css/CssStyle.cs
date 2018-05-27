using System.Collections.Generic;

namespace Blazor.Extensions.CssStyles.Css
{
    public class CssStyle : ValueObject
    {
        public string Name { get; set; }

        public ICssStyleValue Value { get; set; }

        public override string ToString()
        {
            return $"{Name}: {Value.CssRepresentation()};";
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return this.ToString();
        }
    }
}
