using Microsoft.AspNetCore.Blazor.Browser.Interop;

namespace Blazor.MaterialUI
{
    public class MaterialUiJsInterop
    {
        public static string AppendStyle(string message)
        {
            return RegisteredFunction.Invoke<string>(
                "Blazor.MaterialUI.ExampleJsInterop.AppendStyle",
                message);
        }
    }
}
