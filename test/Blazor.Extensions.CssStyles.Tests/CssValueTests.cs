using Blazor.Extensions.CssStyles.Css;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace Blazor.Extensions.CssStyles.Tests
{
    public class CssValueTests
    {
        [Fact]
        public void ShouldBeEqualWhenTwoTextCssValuesHaveSameValue()
        {
            var textValue = new TextCssStyleValue("test");
            var textValue2 = new TextCssStyleValue("test");

            Assert.True(textValue.Equals(textValue2));
        }

        [Fact]
        public void ShouldReturnSameValueWhenTextCssStyleValueIsUsed()
        {
            var textValue = new TextCssStyleValue("test");

            Assert.Equal("test", textValue.CssRepresentation());
        }

        [Theory]
        [ClassData(typeof(UnitesTestData))]
        public void ShouldReturnNumberWithCorrectUnitWhenNumberCssStyleValueIsUsed(CssUnits unit)
        {
            var numberStyleValue = new NumberCssStyleValue(10, unit);

            Assert.Equal($"10{unit.Symbol}", numberStyleValue.CssRepresentation());
        }

        [Fact]
        public void ShouldReturnOneStyleWhenComplexStyleValuesHasTwoDefinitions()
        {
            var complexStyleValue = new ComplexCssStyleValue(new ICssStyleValue[] {
                NumberCssStyleValue.CreatePixelValue(10), TextCssStyleValue.CreateTextValue("dotted")
            });

            Assert.Equal("10px dotted", complexStyleValue.CssRepresentation());
        }

        public class UnitesTestData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { CssUnits.Px };
                yield return new object[] { CssUnits.Cm };
                yield return new object[] { CssUnits.Mm };
                yield return new object[] { CssUnits.Ch };
                yield return new object[] { CssUnits.Em };
                yield return new object[] { CssUnits.Ex };
                yield return new object[] { CssUnits.Inches };
                yield return new object[] { CssUnits.Percentage };
                yield return new object[] { CssUnits.Picas };
                yield return new object[] { CssUnits.Points };
                yield return new object[] { CssUnits.Rem };
                yield return new object[] { CssUnits.VH };
                yield return new object[] { CssUnits.VMax };
                yield return new object[] { CssUnits.VMin };
                yield return new object[] { CssUnits.VW };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
    }
}
