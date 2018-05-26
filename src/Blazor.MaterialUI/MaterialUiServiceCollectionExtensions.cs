using Blazor.Extensions.Logging;
using Blazor.MaterialUI.Css;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Blazor.MaterialUI
{
    public static class MaterialUiServiceCollectionExtensions
    {
        public static IServiceCollection AddMaterialUi(this IServiceCollection services)
        {
            services.AddLogging(builder => builder
                .AddBrowserConsole()
                .SetMinimumLevel(LogLevel.Debug));

            services.AddMaterialUiCss();

            return services;
        }
    }
}
