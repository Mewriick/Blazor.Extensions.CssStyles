using System.Text;

namespace Blazor.MaterialUI.Css
{
    public class MediaCssPattern : CssPattern
    {
        public MediaCssPattern(string name)
            : base(name)
        {
        }

        public override string BuildCssRepresentation(string parentClassName)
        {
            var cssBuilder = new StringBuilder(100);

            cssBuilder.AppendLine($"\n {Name} {{");
            cssBuilder.AppendLine($"\t .{parentClassName} {{");

            foreach (var style in Styles)
            {
                cssBuilder.AppendLine($"\t\t{style.Name}: {style.Value};");
            }

            cssBuilder.AppendLine("\t }");
            cssBuilder.AppendLine("}");

            return cssBuilder.ToString();
        }
    }
}
