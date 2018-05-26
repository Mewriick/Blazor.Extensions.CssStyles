using System.Collections.Generic;

namespace Blazor.MaterialUI.Css
{
    public interface ICssClass : ICss, ICssProperties
    {
        IEnumerable<CssPattern> Patterns { get; }

        void AssignUniqueName();
    }
}
