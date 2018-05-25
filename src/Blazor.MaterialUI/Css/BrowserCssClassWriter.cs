using System;

namespace Blazor.MaterialUI.Css
{
    public class BrowserCssClassWriter : ICssClassWriter
    {
        private readonly ICssClassBuilder cssClassBuilder;

        public BrowserCssClassWriter(ICssClassBuilder cssClassBuilder)
        {
            this.cssClassBuilder = cssClassBuilder ?? throw new ArgumentNullException(nameof(cssClassBuilder));
        }

        public void WriteCssClass(ICssClass cssClass)
        {
            var css = cssClassBuilder.BuildCssClassRepresentaion(cssClass);

            MaterialUiJsInterop.AppendStyle(css);
        }
    }
}
