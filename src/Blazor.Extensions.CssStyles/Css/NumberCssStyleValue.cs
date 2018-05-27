using System;
using System.Collections.Generic;

namespace Blazor.Extensions.CssStyles.Css
{
    public class NumberCssStyleValue : ValueObject, ICssStyleValue
    {
        private int value;
        private CssUnits unit;

        public static NumberCssStyleValue CreatePixelValue(int value) => new NumberCssStyleValue(value, CssUnits.Px);

        public static NumberCssStyleValue CreateEmValue(int value) => new NumberCssStyleValue(value, CssUnits.Em);

        public static NumberCssStyleValue CreateRemValue(int value) => new NumberCssStyleValue(value, CssUnits.Rem);

        public NumberCssStyleValue(int value, CssUnits unit)
        {
            if (unit is null)
            {
                throw new ArgumentNullException(nameof(unit));
            }

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