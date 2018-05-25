using Microsoft.Extensions.DependencyInjection;

namespace Blazor.MaterialUI.Css
{
    public static class MaterialUiCssServiceCollectionExtensions
    {
        public static IServiceCollection AddMaterialUiCss(this IServiceCollection services)
        {
            services.AddSingleton<ICssClassBuilder, CssClassBuilder>();
            services.AddSingleton<ICssClassRealNameProvider, BrowserCssClassRealNameProvider>();
            services.AddSingleton<ICssClassWriter, BrowserCssClassWriter>();

            return services;
        }
    }
}
