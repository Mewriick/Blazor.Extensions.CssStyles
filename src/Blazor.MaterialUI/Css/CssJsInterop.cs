namespace Blazor.Extensions.CssStyles.Css
{
    public class CssJsInterop : ICssJsInterop
    {
        public void AppendCssStyleIntoDom(string cssClass) => CssDomJsInterop.AppendStyle(cssClass);
    }
}
