using Blazor.Extensions.CssStyles.Css;
using System;
using Xunit;

namespace Blazor.Extensions.CssStyles.Tests
{
    public class RuleBasedCssClassNamesTests
    {
        [Fact]
        public void ShouldRenderTwoClassesWhenOneClassIsAlwaysApplied()
        {
            var classNames = new RuleBasedCssClassNames()
                                .AddCssClass("foo")
                                .AddCssClassApplyRule("bar", () => true)
                                .AddCssClassApplyRule("baz", () => false);

            Assert.Equal("foo bar", classNames.BuildCssClassNames());
        }

        [Fact]
        public void ShouldRenderTwoClassesWhenMethodsAreUsedsAsApplyRule()
        {
            bool Test()
            {
                return true;
            }

            bool Test2()
            {
                return 1 > 2;
            }

            var classNames = new RuleBasedCssClassNames()
                                .AddCssClass("foo")
                                .AddCssClassApplyRule("bar", Test)
                                .AddCssClassApplyRule("baz", Test2);

            Assert.Equal("foo bar", classNames.BuildCssClassNames());
        }

        [Fact]
        public void ShouldThrowArgumentExceptionWhenForClassIsDefinedRule()
        {
            Assert.Throws<ArgumentException>(() => new RuleBasedCssClassNames()
                               .AddCssClass("foo")
                               .AddCssClassApplyRule("foo", () => true));
        }

        [Fact]
        public void ShouldThrowArgumentExceptionWhenCssClassNameIsEmpty()
        {
            Assert.Throws<ArgumentNullException>(() => new RuleBasedCssClassNames()
                               .AddCssClass("")
                               .AddCssClassApplyRule("bar", () => true));
        }

        [Fact]
        public void ShouldThrowArgumentExceptionWhenApplyRuleIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => new RuleBasedCssClassNames()
                               .AddCssClass("foo")
                               .AddCssClassApplyRule("foo", null));
        }
    }
}
