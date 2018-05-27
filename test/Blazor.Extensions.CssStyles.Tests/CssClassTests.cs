using Blazor.Extensions.CssStyles.Css;
using Xunit;

namespace Blazor.Extensions.CssStyles.Tests
{
    public class CssClassTests
    {
        [Fact]
        public void TwoSameDefinedCssClassesShouldBeEqual()
        {
            var cssClass = new CssClass("Button")
                    .WithStyle("color", "green")
                    .WithStyle("margin", "20px")
                    .WithPixelStyle("padding-left", 12)
                    .WithStyle("padding-bottom", 15, CssUnits.Em)
                        .AddPseudoSelector(PseudoSelector.Hover, props => props
                            .WithStyle("color", "red")
                            .WithStyle("width", "20px"))
                       .AddMediaQuery("@media (min-width: 1024px)", props =>
                            props.WithStyle("width", "50px"));

            var cssClass2 = new CssClass("Button")
                    .WithStyle("color", "green")
                    .WithStyle("margin", "20px")
                    .WithPixelStyle("padding-left", 12)
                    .WithStyle("padding-bottom", 15, CssUnits.Em)
                        .AddPseudoSelector(PseudoSelector.Hover, props => props
                            .WithStyle("color", "red")
                            .WithStyle("width", "20px"))
                       .AddMediaQuery("@media (min-width: 1024px)", props =>
                            props.WithStyle("width", "50px"));

            Assert.True(cssClass.Equals(cssClass2));
        }
    }
}
