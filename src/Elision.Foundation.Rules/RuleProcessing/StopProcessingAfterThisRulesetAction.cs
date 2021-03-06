using Sitecore.Rules.Actions;

namespace Elision.Foundation.Rules.RuleProcessing
{
    public class StopProcessingAfterThisRulesetAction<T> : RuleAction<T> where T : EnhancedRuleContext
    {
        public override void Apply(T ruleContext)
        {
            ruleContext.StopProcessingAfterThisRuleset = true;
        }
    }
}
