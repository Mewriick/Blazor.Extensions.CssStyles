using Blazor.Extensions.CssStyles.Css;
using Xunit;

namespace Blazor.Extensions.CssStyles.Tests
{
    public class CssPatternTests
    {
        [Fact]
        public void ShouldRenderClassWithPseudoClassWithOneStyle()
        {
            var cssPattern = new CssPattern(PseudoSelector.Hover.CssRenderedValue);
            cssPattern.WithStyle("test", "testValue");

            var expectedResult = "\n .class:hover {\r\n\ttest: testValue;\r\n}";

            Assert.Equal(expectedResult, cssPattern.BuildCssRepresentation("class"));
        }

        [Fact]
        public void ShouldRenderClassWithPseudoClassWithTwoStyles()
        {
            var cssPattern = new CssPattern(PseudoSelector.Hover.CssRenderedValue);
            cssPattern.WithStyle("test", "testValue");
            cssPattern.WithStyle("test2", "testValue2");

            var expectedResult = "\n .class:hover {\r\n\ttest: testValue;\r\n\ttest2: testValue2;\r\n}";

            Assert.Equal(expectedResult, cssPattern.BuildCssRepresentation("class"));
        }

        [Fact]
        public void ShouldRenderMediaAroundCssClass()
        {
            var cssPattern = new MediaCssPattern("@media(min-width: 1024px)");
            cssPattern.WithStyle("test", "testValue");
            cssPattern.WithStyle("test2", "testValue2");

            var expectedResult = "\n @media(min-width: 1024px) {\r\n\t .class {\r\n\t\ttest: testValue;\r\n\t\ttest2: testValue2;\r\n\t }\r\n}";

            Assert.Equal(expectedResult, cssPattern.BuildCssRepresentation("class"));
        }
    }
}
