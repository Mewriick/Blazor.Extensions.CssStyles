using Microsoft.AspNetCore.Blazor.Browser.Interop;

namespace Blazor.Extensions.CssStyles
{
    public class CssDomJsInterop
    {
        public static string AppendStyle(string css)
        {
            return RegisteredFunction.Invoke<string>(
                "Blazor.MaterialUI.ExampleJsInterop.AppendStyle",
                css);
        }
    }
}
