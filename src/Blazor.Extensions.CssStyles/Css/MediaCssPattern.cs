using System.Text;

namespace Blazor.Extensions.CssStyles.Css
{
    public class MediaCssPattern : CssPattern
    {
        private const int BuilderStartingCapacity = 100;


        public MediaCssPattern(string name)
            : base(name)
        {
        }

        public override string BuildCssRepresentation(string parentClassName)
        {
            var cssBuilder = new StringBuilder(BuilderStartingCapacity);

            cssBuilder.AppendLine($"\n {Name} {{");
            cssBuilder.AppendLine($"\t .{parentClassName} {{");

            foreach (var style in Styles)
            {
                cssBuilder.AppendLine($"\t\t{style}");
            }

            cssBuilder.AppendLine("\t }");
            cssBuilder.Append("}");

            return cssBuilder.ToString();
        }
    }
}
