using System;
using System.Text;

namespace Blazor.Extensions.CssStyles.Css
{
    public class CssPattern : CssProperties, ICss
    {
        public string Name { get; }

        public CssPattern(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

        public virtual string BuildCssRepresentation(string parentClassName)
        {
            if (string.IsNullOrWhiteSpace(parentClassName))
            {
                throw new ArgumentNullException(nameof(parentClassName));
            }

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
