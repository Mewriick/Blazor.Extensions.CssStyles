using Blazor.MaterialUI.Css;
using Microsoft.AspNetCore.Blazor.Browser.Rendering;
using Microsoft.AspNetCore.Blazor.Browser.Services;

namespace DemoApp.Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new BrowserServiceProvider(services =>
            {
                // Add any custom services here
                services.AddMaterialUiCss();
            });

            new BrowserRenderer(serviceProvider).AddComponent<App>("app");
        }
    }
}
