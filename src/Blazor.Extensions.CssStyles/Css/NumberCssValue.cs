using System.Collections.Generic;

namespace Blazor.Extensions.CssStyles.Css
{
    public class NumberCssValue : ValueObject, ICssValue
    {
        private int value;
        private CssUnits unit;

        public NumberCssValue(int value, CssUnits unit)
        {
            this.value = value;
            this.unit = unit;
        }

        public string CssRepresentation()
        {
            return $"{value}{unit.Symbol}";
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return value;
            yield return unit;
        }
    }
}
