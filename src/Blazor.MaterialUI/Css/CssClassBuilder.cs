namespace Blazor.MaterialUI.Css
{
    public class CssClassBuilder : ICssClassBuilder
    {
        public string BuildCssClassRepresentaion(ICssClass cssClass)
        {
            return ".dummy {" +
                 "color: red" +
                "}";
        }
    }
}
