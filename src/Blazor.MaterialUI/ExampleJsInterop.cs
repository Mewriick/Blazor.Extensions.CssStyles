using System;
using Microsoft.AspNetCore.Blazor.Browser.Interop;

namespace Blazor.MaterialUI
{
    public class ExampleJsInterop
    {
        public static string Prompt(string message)
        {
            return RegisteredFunction.Invoke<string>(
                "Blazor.MaterialUI.ExampleJsInterop.Prompt",
                message);
        }
    }
}
