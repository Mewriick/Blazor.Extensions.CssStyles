namespace Blazor.Extensions.CssStyles.Css
{
    public interface ICssClassesCache
    {
        bool CssClassIsAlreadyRealized(ICssClass cssClass);

        void StoreCssClassRealName(ICssClass cssClass);
    }
}
