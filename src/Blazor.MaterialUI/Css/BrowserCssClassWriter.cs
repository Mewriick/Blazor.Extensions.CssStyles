using Microsoft.Extensions.Logging;
using System;

namespace Blazor.MaterialUI.Css
{
    public class BrowserCssClassWriter : ICssClassWriter
    {
        private readonly ICssClassBuilder cssClassBuilder;
        private readonly ICssClassesCache cssClassesCache;
        private readonly ICssJsInterop cssJsInterop;
        private readonly ILogger<BrowserCssClassWriter> logger;

        public BrowserCssClassWriter(
            ICssClassBuilder cssClassBuilder,
            ICssClassesCache cssClassesCache,
            ICssJsInterop cssJsInterop,
            ILogger<BrowserCssClassWriter> logger)
        {
            this.cssClassBuilder = cssClassBuilder ?? throw new ArgumentNullException(nameof(cssClassBuilder));
            this.cssClassesCache = cssClassesCache ?? throw new ArgumentNullException(nameof(cssClassesCache));
            this.cssJsInterop = cssJsInterop ?? throw new ArgumentNullException(nameof(cssJsInterop));
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public void WriteCssClass(ICssClass cssClass)
        {
            cssClass.AssignUniqueName();

            if (cssClassesCache.CssClassIsAlreadyRealized(cssClass))
            {
                logger.LogInformation($"Css class [{cssClass.Name}] is already realized in HTML DOM");

                return;
            }

            var css = cssClassBuilder.BuildCssClassRepresentaion(cssClass);

            cssJsInterop.AppendCssStyleIntoDom(css);
            cssClassesCache.StoreCssClassRealName(cssClass);
        }
    }
}
