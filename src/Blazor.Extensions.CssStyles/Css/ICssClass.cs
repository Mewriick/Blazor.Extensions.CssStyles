using System.Collections.Generic;

namespace Blazor.Extensions.CssStyles.Css
{
    public interface ICssClass : ICss, ICssProperties
    {
        IEnumerable<CssPattern> Patterns { get; }

        void AssignUniqueName();
    }
}
