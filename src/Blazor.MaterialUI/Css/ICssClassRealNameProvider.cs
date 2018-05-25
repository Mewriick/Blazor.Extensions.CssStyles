namespace Blazor.MaterialUI.Css
{
    public interface ICssClassRealNameProvider
    {
        string GetRealCssClassName(ICssClass cssClass);

        void StoreRealCssClassName(ICssClass cssClass, string realName);
    }
}
