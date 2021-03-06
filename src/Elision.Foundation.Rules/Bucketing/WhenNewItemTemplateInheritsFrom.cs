﻿using Elision.Foundation.Kernel;
using Sitecore.Buckets.Rules.Bucketing;
using Sitecore.Buckets.Rules.Bucketing.Conditions;

namespace Elision.Foundation.Rules.Bucketing
{
    public class WhenNewItemTemplateInheritsFrom<T> : WhenNewItemTemplateIs<T> where T : BucketingRuleContext
    {
        protected override bool Execute(T ruleContext)
        {
            var result = base.Execute(ruleContext);
            if (result) return true;

            var template = ruleContext.Database.GetTemplate(ruleContext.NewItemTemplateId);
            return template != null && template.InheritsFrom(TemplateId);
        }
    }
}
