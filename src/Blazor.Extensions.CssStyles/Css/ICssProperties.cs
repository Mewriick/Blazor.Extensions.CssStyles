using System.Collections.Generic;

namespace Blazor.Extensions.CssStyles.Css
{
    public interface ICssProperties
    {
        IEnumerable<CssStyle> Styles { get; }

        ICssProperties AddStyle(string name, string value);
    }
}
