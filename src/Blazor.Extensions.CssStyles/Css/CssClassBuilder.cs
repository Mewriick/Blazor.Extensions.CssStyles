using Microsoft.Extensions.Logging;
using System;
using System.Text;

namespace Blazor.Extensions.CssStyles.Css
{
    public class CssClassBuilder : ICssClassBuilder
    {
        private const int BuilderStartingCapacity = 100;

        private readonly ILogger<CssClassBuilder> logger;
        private readonly StringBuilder cssBuilder;

        public CssClassBuilder(ILogger<CssClassBuilder> logger)
        {
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
            this.cssBuilder = new StringBuilder(BuilderStartingCapacity);
        }

        public string BuildCssClassRepresentaion(ICssClass cssClass)
        {
            if (cssClass is null)
            {
                throw new ArgumentNullException(nameof(cssClass));
            }

            logger.LogInformation($"Start building css class representaion for [{cssClass.Name}]");

            AppendCssClass(cssClass.Name, cssClass);

            foreach (var pattern in cssClass.Patterns)
            {
                cssBuilder.AppendLine(pattern.BuildCssRepresentation(cssClass.Name));
            }

            var classRepresentation = cssBuilder.ToString();
            cssBuilder.Clear();

            return classRepresentation;
        }

        private void AppendCssClass(string className, ICssProperties cssProperties)
        {
            cssBuilder.AppendLine($"\n .{className} {{");
            foreach (var style in cssProperties.Styles)
            {
                cssBuilder.AppendLine($"\t{style.Name}: {style.Value};");
            }

            cssBuilder.Append("}");
        }
    }
}
