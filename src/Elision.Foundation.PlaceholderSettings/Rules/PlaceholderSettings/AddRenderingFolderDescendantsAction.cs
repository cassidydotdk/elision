using System.Linq;
using Sitecore.Data;
using Sitecore.Rules.Actions;

namespace Elision.Foundation.PlaceholderSettings.Rules.PlaceholderSettings
{
    public class AddRenderingFolderDescendantsAction<T> : RuleAction<T> where T : PlaceholderSettingsRuleContext
    {
        public string RenderingFolderItemId { get; set; }

        public override void Apply(T ruleContext)
        {
            if (!ID.IsID(RenderingFolderItemId)) return;

            var folder = ruleContext.Args.ContentDatabase.GetItem(RenderingFolderItemId);
            if (folder == null) return;

            var renderings = folder
                .Axes.GetDescendants()
                .Where(x => x.Template.BaseTemplates.Any(t => t.ID.ToString() == "{D1592226-3898-4CE2-B190-090FD5F84A4C}"));

            foreach (var rendering in renderings.Where(r => ruleContext.Args.PlaceholderRenderings.All(x => x.ID != r.ID)))
            {
                ruleContext.Args.PlaceholderRenderings.Add(rendering);
            }
        }
    }
}
