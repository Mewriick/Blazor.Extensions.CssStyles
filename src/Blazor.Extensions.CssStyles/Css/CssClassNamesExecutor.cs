using System;
using System.Linq;

namespace Blazor.Extensions.CssStyles.Css
{
    public class CssClassNamesExecutor : ICssClassNamesExecutor
    {
        public string BuildCssClassNames(params ICssClassNames[] cssClassNames)
        {
            if (cssClassNames is null)
            {
                throw new ArgumentNullException(nameof(cssClassNames));
            }

            if (!cssClassNames.Any())
            {
                return string.Empty;
            }

            if (cssClassNames.Length == 1)
            {
                return cssClassNames[0].BuildCssClassNames();
            }

            var compositedCssClasses = string.Join(" ", cssClassNames.Select(c => c.BuildCssClassNames()));

            return compositedCssClasses;
        }
    }
}
