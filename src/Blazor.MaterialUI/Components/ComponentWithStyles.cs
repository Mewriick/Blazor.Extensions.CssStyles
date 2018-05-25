using Blazor.MaterialUI.Css;
using Microsoft.AspNetCore.Blazor.Components;
using System.Collections.Generic;

namespace Blazor.MaterialUI.Components
{
    public class ComponentWithStyles : BlazorComponent
    {
        [Parameter]
        protected List<CssClass> CssClasses { get; set; }

        public ComponentWithStyles()
        {

        }
    }
}
