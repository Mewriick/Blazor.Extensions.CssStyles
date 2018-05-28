using Blazor.Extensions.CssStyles.Css;
using Blazor.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Blazor.Extensions.CssStyles
{
    public static class MaterialUiCssServiceCollectionExtensions
    {
        public static IServiceCollection AddCss(this IServiceCollection services)
        {
            services.AddLogging(builder => builder
                .AddBrowserConsole()
                .SetMinimumLevel(LogLevel.Debug));

            services.AddSingleton<ICssClassBuilder, CssClassBuilder>();
            services.AddSingleton<ICssClassesCache, MemoryCssClassesCache>();
            services.AddSingleton<ICssJsInterop, CssJsInterop>();
            services.AddSingleton<ICssClassWriter, BrowserCssClassWriter>();
            services.AddSingleton<ICssClassNamesExecutor, CssClassNamesExecutor>();

            return services;
        }
    }
}
