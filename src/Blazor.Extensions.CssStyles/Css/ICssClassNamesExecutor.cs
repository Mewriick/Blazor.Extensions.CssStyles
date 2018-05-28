namespace Blazor.Extensions.CssStyles.Css
{
    public interface ICssClassNamesExecutor
    {
        string BuildCssClassNames(params ICssClassNames[] cssClassNames);
    }
}