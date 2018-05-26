using Microsoft.Extensions.DependencyInjection;

namespace Blazor.MaterialUI.Css
{
    public static class MaterialUiCssServiceCollectionExtensions
    {
        public static IServiceCollection AddMaterialUiCss(this IServiceCollection services)
        {
            services.AddSingleton<ICssClassBuilder, CssClassBuilder>();
            services.AddSingleton<ICssClassesCache, MemoryCssClassesCache>();
            services.AddSingleton<ICssJsInterop, CssJsInterop>();
            services.AddSingleton<ICssClassWriter, BrowserCssClassWriter>();

            return services;
        }
    }
}
