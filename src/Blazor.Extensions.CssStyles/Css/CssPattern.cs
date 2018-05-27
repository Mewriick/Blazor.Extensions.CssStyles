using System.Text;

namespace Blazor.Extensions.CssStyles.Css
{
    public class CssPattern : CssProperties, ICss
    {
        public string Name { get; }

        public CssPattern(string name)
        {
            Name = name;
        }

        public virtual string BuildCssRepresentation(string parentClassName)
        {
            var cssBuilder = new StringBuilder(100);

            cssBuilder.AppendLine($"\n .{parentClassName}:{Name} {{");

            foreach (var style in Styles)
            {
                cssBuilder.AppendLine($"\t{style}");
            }

            cssBuilder.Append("}");

            return cssBuilder.ToString();
        }
    }
}
