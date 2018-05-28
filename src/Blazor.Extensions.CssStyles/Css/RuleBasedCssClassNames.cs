using System;
using System.Collections.Generic;
using System.Linq;

namespace Blazor.Extensions.CssStyles.Css
{
    public class RuleBasedCssClassNames : ICssClassNames
    {
        private readonly Dictionary<string, Func<bool>> cssClassApplyRules;
        private readonly Dictionary<ICssClass, Func<bool>> computedCssClassApplyRules;

        public RuleBasedCssClassNames()
        {
            this.cssClassApplyRules = new Dictionary<string, Func<bool>>();
            this.computedCssClassApplyRules = new Dictionary<ICssClass, Func<bool>>();
        }

        public RuleBasedCssClassNames AddCssClass(ICssClass cssClass)
        {
            AddCssClassApplyRule(cssClass, () => true);

            return this;
        }

        public RuleBasedCssClassNames AddCssClass(string className)
        {
            AddCssClassApplyRule(className, () => true);

            return this;
        }

        public RuleBasedCssClassNames AddCssClassApplyRule(ICssClass cssClass, Func<bool> applyRule)
        {
            cssClass.AssignUniqueName();
            AddCssClassApplyRule(cssClass.Name, applyRule);

            return this;
        }

        public RuleBasedCssClassNames AddCssClassApplyRule(string className, Func<bool> applyRule)
        {
            CheckParams(className, applyRule);

            if (cssClassApplyRules.ContainsKey(className))
            {
                throw new ArgumentException($"For the css class [{className}] already exists rule when css class should be in use.");
            }

            cssClassApplyRules.Add(className, applyRule);

            return this;
        }

        public string BuildCssClassNames()
        {
            var classNames = string.Join(" ", cssClassApplyRules
                .Where(apr => apr.Value())
                .Select(apr => apr.Key));

            return classNames;
        }

        private void CheckParams(string className, Func<bool> applyRule)
        {
            if (string.IsNullOrWhiteSpace(className))
            {
                throw new ArgumentNullException(nameof(className));
            }

            if (applyRule is null)
            {
                throw new ArgumentNullException(nameof(applyRule));
            }
        }
    }
}
