using Blazor.Extensions.CssStyles.Css;
using Microsoft.Extensions.Logging.Abstractions;
using Xunit;

namespace Blazor.Extensions.CssStyles.Tests
{
    public class CssClassBuilderTests
    {
        [Fact]
        public void ShouldRenderOneCssClassWithTwoStyles()
        {
            var cssClass = new CssClass("Button")
                .WithStyle(CssPropertyNames.Color, "green")
                .WithStyle(CssPropertyNames.Margin, "20px");

            var cssClassBuilder = new CssClassBuilder(NullLogger<CssClassBuilder>.Instance);
            var expectedResult = "\n .Button {\r\n\tcolor: green;\r\n\tmargin: 20px;\r\n}";

            var cssRepresentation = cssClassBuilder.BuildCssClassRepresentaion(cssClass);

            Assert.Equal(expectedResult, cssRepresentation);
        }

        [Fact]
        public void ShouldRenderOneCssClassWithTwoStylesAndClassWithSelector()
        {
            var cssClass = new CssClass("Button")
                .WithStyle(CssPropertyNames.Color, "green")
                .WithStyle(CssPropertyNames.Margin, "20px")
                .AddPseudoSelector(PseudoSelector.Hover, props =>
                    props.WithStyle(CssPropertyNames.Color, "red").WithlStyleInPixelUnit(CssPropertyNames.Margin, 50));

            var cssClassBuilder = new CssClassBuilder(NullLogger<CssClassBuilder>.Instance);
            var expectedResult = "\n .Button {\r\n\tcolor: green;\r\n\tmargin: 20px;\r\n}\n " +
                ".Button:hover {\r\n\tcolor: red;\r\n\tmargin: 50px;\r\n}\r\n";

            var cssRepresentation = cssClassBuilder.BuildCssClassRepresentaion(cssClass);

            Assert.Equal(expectedResult, cssRepresentation);
        }

        [Fact]
        public void ShouldRenderOneCssClassWithTwoStylesAndTwoClassWithSelectors()
        {
            var cssClass = new CssClass("Button")
                .WithStyle(CssPropertyNames.Color, "green")
                .WithStyle(CssPropertyNames.Margin, "20px")
                .AddPseudoSelector(PseudoSelector.Hover, props =>
                    props.WithStyle(CssPropertyNames.Color, "red").WithlStyleInPixelUnit(CssPropertyNames.Margin, 50))
                .AddPseudoSelector(PseudoSelector.Focus, props =>
                    props.WithStyle(CssPropertyNames.Color, "red").WithlStyleInPixelUnit(CssPropertyNames.Margin, 50));

            var cssClassBuilder = new CssClassBuilder(NullLogger<CssClassBuilder>.Instance);
            var expectedResult = "\n .Button {\r\n\tcolor: green;\r\n\tmargin: 20px;\r\n}\n " +
                ".Button:hover {\r\n\tcolor: red;\r\n\tmargin: 50px;\r\n}\r\n\n " +
                ".Button:focus {\r\n\tcolor: red;\r\n\tmargin: 50px;\r\n}\r\n";

            var cssRepresentation = cssClassBuilder.BuildCssClassRepresentaion(cssClass);

            Assert.Equal(expectedResult, cssRepresentation);
        }

        [Fact]
        public void ShouldRenderOneCssClassWithTwoStylesAndClassWithSelectorAndMediaQueryForClass()
        {
            var cssClass = new CssClass("Button")
                .WithStyle(CssPropertyNames.Color, "green")
                .WithStyle(CssPropertyNames.Margin, "20px")
                .AddPseudoSelector(PseudoSelector.Hover, props =>
                    props.WithStyle(CssPropertyNames.Color, "red").WithlStyleInPixelUnit(CssPropertyNames.Margin, 50))
                .AddMediaQuery("@media(min-width: 1024px)", props =>
                    props.WithlStyleInPixelUnit(CssPropertyNames.Margin, 50).WithStyle(CssPropertyNames.Color, "green"));

            var cssClassBuilder = new CssClassBuilder(NullLogger<CssClassBuilder>.Instance);
            var expectedResult = "\n .Button {\r\n\tcolor: green;\r\n\tmargin: 20px;\r\n}\n " +
                ".Button:hover {\r\n\tcolor: red;\r\n\tmargin: 50px;\r\n}\r\n\n" +
                " @media(min-width: 1024px) {\r\n\t .Button {\r\n\t\tmargin: 50px;\r\n\t\tcolor: green;\r\n\t }\r\n}\r\n";

            var cssRepresentation = cssClassBuilder.BuildCssClassRepresentaion(cssClass);

            Assert.Equal(expectedResult, cssRepresentation);
        }
    }
}
