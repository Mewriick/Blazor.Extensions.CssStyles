using Microsoft.AspNetCore.Blazor.Browser.Interop;

namespace Blazor.MaterialUI
{
    public class MaterialUiJsInterop
    {
        public static string AppendStyle(string css)
        {
            return RegisteredFunction.Invoke<string>(
                "Blazor.MaterialUI.ExampleJsInterop.AppendStyle",
                css);
        }
    }
}
