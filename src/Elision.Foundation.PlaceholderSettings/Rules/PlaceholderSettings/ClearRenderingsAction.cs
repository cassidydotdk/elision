using Sitecore.Rules.Actions;

namespace Elision.Foundation.PlaceholderSettings.Rules.PlaceholderSettings
{
    public class ClearRenderingsAction<T> : RuleAction<T> where T : PlaceholderSettingsRuleContext
    {
        public override void Apply(T ruleContext)
        {
            ruleContext.Args.PlaceholderRenderings.Clear();
        }
    }
}
