namespace Blazor.MaterialUI.Css
{
    public interface ICssClassesCache
    {
        bool CssClassIsAlreadyRealized(ICssClass cssClass);

        void StoreCssClassRealName(ICssClass cssClass);
    }
}
