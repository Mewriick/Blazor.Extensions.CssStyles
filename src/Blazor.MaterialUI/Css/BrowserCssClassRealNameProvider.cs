using System.Collections.Generic;

namespace Blazor.MaterialUI.Css
{
    public class BrowserCssClassRealNameProvider : ICssClassRealNameProvider
    {
        private readonly Dictionary<int, string> cssClassRealNameMapping;

        public BrowserCssClassRealNameProvider()
        {
            this.cssClassRealNameMapping = new Dictionary<int, string>();
        }

        public string GetRealCssClassName(ICssClass cssClass)
        {
            var cssClassHash = cssClass.GetHashCode();
            if (cssClassRealNameMapping.ContainsKey(cssClassHash))
            {
                return cssClassRealNameMapping[cssClassHash];
            }

            return string.Empty;
        }

        public void StoreRealCssClassName(ICssClass cssClass, string realName)
        {
            cssClassRealNameMapping.Add(cssClass.GetHashCode(), realName);
        }
    }
}
