using Blazor.Extensions.CssStyles;
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
                services.AddCss();
            });

            new BrowserRenderer(serviceProvider).AddComponent<App>("app");
        }
    }
}
