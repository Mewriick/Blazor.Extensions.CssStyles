using System.Collections.Generic;

namespace Blazor.Extensions.CssStyles.Css
{
    public interface ICssProperties
    {
        IEnumerable<CssStyle> Styles { get; }

        ICssProperties WithStyle(string name, string value);
    }
}
