using System;
using System.Collections.Generic;

namespace Blazor.MaterialUI.Css
{
    public class RuleBasedCssClassNames : ICssClassNames
    {
        private readonly Dictionary<ICssClass, Func<bool>> cssClassApplyRules;

        public RuleBasedCssClassNames()
        {
            this.cssClassApplyRules = new Dictionary<ICssClass, Func<bool>>();
        }

        public RuleBasedCssClassNames AddCssClassApplyRule(ICssClass cssClass, Func<bool> applyRule)
        {
            if (cssClassApplyRules.ContainsKey(cssClass))
            {
                throw new ArgumentException($"For the css class [{cssClass.Name}] already exists rule when css class should be in use.");
            }

            cssClassApplyRules.Add(cssClass, applyRule);

            return this;
        }

        public string BuildCssClassNames()
        {
            var classNames = string.Empty;

            foreach (var classApplyRulePair in cssClassApplyRules)
            {
                var applyRule = classApplyRulePair.Value;
                var cssClas = classApplyRulePair.Key;
                if (applyRule())
                {
                    classNames = $"{classNames} {cssClas.Name}";
                }
            }

            return classNames.TrimStart();
        }
    }
}
