namespace Blazor.MaterialUI.Css
{
    public class CssJsInterop : ICssJsInterop
    {
        public void AppendCssStyleIntoDom(string cssClass) => MaterialUiJsInterop.AppendStyle(cssClass);
    }
}
