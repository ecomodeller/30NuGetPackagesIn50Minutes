using WindowsFormsApplication1.Entities;
using WindowsFormsApplication1.Interfaces;
using IronScheme.Hosting;
using IronScheme.Scripting;

namespace WindowsFormsApplication1.Implementations.RuleRunners
{
    public class SchemeRuleRunner : IRuleRunner
    {
        public RuleLanguage RuleLanguage { get { return RuleLanguage.Scheme; } }
        public bool RunRule(string content)
        {
            var slp = ScriptDomainManager.CurrentManager.GetLanguageProvider(typeof(IronSchemeLanguageProvider));
            var se = slp.GetEngine();
            
            return se.EvaluateAs<bool>(content);
        }
    }
}