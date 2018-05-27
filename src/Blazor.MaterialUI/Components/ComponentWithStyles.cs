using Blazor.Extensions.CssStyles.Css;
using Microsoft.AspNetCore.Blazor.Components;

namespace Blazor.Extensions.CssStyles.Components
{
    public class ComponentWithStyles : BlazorComponent
    {
        [Inject]
        protected ICssClassWriter CssClassWriter { get; private set; }

        public ComponentWithStyles()
        {

        }

        protected void ExportStyles(params ICssClass[] cssClasses)
        {
            CssClassWriter.WriteCssClass(cssClasses);
        }
    }
}
