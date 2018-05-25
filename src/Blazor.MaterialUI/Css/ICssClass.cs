using System.Collections.Generic;

namespace Blazor.MaterialUI.Css
{
    public interface ICssClass
    {
        string Name { get; }

        IEnumerable<CssStyle> Styles { get; }

        IDictionary<string, ICssClass> Selectors { get; }
    }
}
