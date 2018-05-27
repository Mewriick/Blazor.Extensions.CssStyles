using Blazor.Extensions.CssStyles.Css;
using System;
using Xunit;

namespace Blazor.Extensions.CssStyles.Tests
{
    public class CssClassTests
    {
        [Fact]
        public void ShouldBeEqualWhenTwoSameDefinedCssClasses()
        {
            var cssClass = new CssClass("Button")
                    .WithStyle(CssPropertyNames.Color, "green")
                    .WithStyle(CssPropertyNames.Margin, "20px")
                    .WithlStyleInPixelUnit(CssPropertyNames.PaddingLeft, 12)
                    .WithStyle(CssPropertyNames.PaddingBottom, 15, CssUnits.Em)
                    .WithStyle(CssPropertyNames.Border, NumberCssStyleValue.CreatePixelValue(5), TextCssStyleValue.CreateTextValue("dotted"))
                    .AddPseudoSelector(PseudoSelector.Hover, props => props
                        .WithStyle(CssPropertyNames.Color, "red")
                        .WithStyle(CssPropertyNames.Width, "20px"))
                    .AddMediaQuery("@media (min-width: 1024px)", props =>
                        props.WithStyle(CssPropertyNames.Width, "50px"));

            var cssClass2 = new CssClass("Button")
                        .WithStyle(CssPropertyNames.Color, "green")
                        .WithStyle(CssPropertyNames.Margin, "20px")
                        .WithlStyleInPixelUnit(CssPropertyNames.PaddingLeft, 12)
                        .WithStyle(CssPropertyNames.PaddingBottom, 15, CssUnits.Em)
                        .WithStyle(CssPropertyNames.Border, NumberCssStyleValue.CreatePixelValue(5), TextCssStyleValue.CreateTextValue("dotted"))
                        .AddPseudoSelector(PseudoSelector.Hover, props => props
                            .WithStyle(CssPropertyNames.Color, "red")
                            .WithStyle(CssPropertyNames.Width, "20px"))
                       .AddMediaQuery("@media (min-width: 1024px)", props =>
                            props.WithStyle(CssPropertyNames.Width, "50px"));

            Assert.True(cssClass.Equals(cssClass2));
        }

        [Fact]
        public void ShouldNotBeEqualWhenTwoDefinedCssClassesHasDifferentNames()
        {
            var cssClass = new CssClass("Button")
                    .WithStyle(CssPropertyNames.Color, "green")
                    .WithStyle(CssPropertyNames.Margin, "20px");


            var cssClass2 = new CssClass("Button1")
                        .WithStyle(CssPropertyNames.Color, "green")
                        .WithStyle(CssPropertyNames.Margin, "20px");

            Assert.False(cssClass.Equals(cssClass2));
        }

        [Fact]
        public void ShouldNotBeEqualWhenTwoDefinedCssClassesHasDifferentAtLeastOneStlye()
        {
            var cssClass = new CssClass("Button")
                    .WithStyle(CssPropertyNames.Color, "green")
                    .WithStyle(CssPropertyNames.Margin, "20px");


            var cssClass2 = new CssClass("Button")
                        .WithStyle(CssPropertyNames.Color, "green")
                        .WithStyle(CssPropertyNames.Margin, "15px");

            Assert.False(cssClass.Equals(cssClass2));
        }

        [Fact]
        public void ShouldThrowArgumentNullExceptionWhenAddedStyleNameIsEmpty()
        {
            var cssClass = new CssClass("Button");

            Assert.Throws<ArgumentNullException>(() => cssClass.WithStyle(string.Empty, "test"));
        }

        [Fact]
        public void ShouldThrowArgumentNullExceptionWhenAddedStyleValueIsEmpty()
        {
            var cssClass = new CssClass("Button");

            Assert.Throws<ArgumentNullException>(() => cssClass.WithStyle("test", string.Empty));
        }

        [Fact]
        public void ShouldThrowArgumentNullExceptionWhenAddedSelectorIsNull()
        {
            var cssClass = new CssClass("Button");

            Assert.Throws<ArgumentNullException>(() => cssClass.AddPseudoSelector(null, p => p.WithStyle("test", "test")));
        }


        [Fact]
        public void ShouldThrowArgumentNullExceptionWhenAddedSelectorConfigureActionIsNull()
        {
            var cssClass = new CssClass("Button");

            Assert.Throws<ArgumentNullException>(() => cssClass.AddPseudoSelector(PseudoSelector.Active, null));
        }

        [Fact]
        public void ShouldThrowArgumentNullExceptionWhenAddedMediaIsNull()
        {
            var cssClass = new CssClass("Button");

            Assert.Throws<ArgumentNullException>(() => cssClass.AddMediaQuery(null, p => p.WithStyle("test", "test")));
        }


        [Fact]
        public void ShouldThrowArgumentNullExceptionWhenAddedMediaConfigureActionIsNull()
        {
            var cssClass = new CssClass("Button");

            Assert.Throws<ArgumentNullException>(() => cssClass.AddMediaQuery("test", null));
        }
    }
}
