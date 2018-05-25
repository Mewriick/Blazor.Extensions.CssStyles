using System.Collections.Generic;

namespace Blazor.MaterialUI.Css
{
    public class CssClass : ICssClass
    {
        public string Name { get; private set; }

        public IEnumerable<CssStyle> Styles { get; }

        public IDictionary<string, ICssClass> Selectors { get; }

        public CssClass(string name)
        {
            Name = name;

            Styles = new List<CssStyle>();
            Selectors = new Dictionary<string, ICssClass>();
        }
    }
}
