using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace Blazor.Extensions.CssStyles.Css
{
    public class MemoryCssClassesCache : ICssClassesCache
    {
        private readonly HashSet<string> realizedCssClasses;
        private readonly ILogger<MemoryCssClassesCache> logger;

        public MemoryCssClassesCache(ILogger<MemoryCssClassesCache> logger)
        {
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
            this.realizedCssClasses = new HashSet<string>();
        }


        public void StoreCssClassRealName(ICssClass cssClass)
        {
            realizedCssClasses.Add(cssClass.Name);
        }

        public bool CssClassIsAlreadyRealized(ICssClass cssClass)
        {
            if (realizedCssClasses.Contains(cssClass.Name))
            {
                logger.LogInformation($"Css class [{cssClass.Name}] found in cahce");

                return true;
            }

            return false;
        }
    }
}
