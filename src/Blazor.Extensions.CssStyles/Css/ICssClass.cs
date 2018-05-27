using System.Collections.Generic;

namespace Blazor.Extensions.CssStyles.Css
{
    public interface ICssClass : ICss, ICssProperties
    {
        SelectorType SelectorType { get; }

        IEnumerable<CssPattern> Patterns { get; }

        void AssignUniqueName();
    }
}
