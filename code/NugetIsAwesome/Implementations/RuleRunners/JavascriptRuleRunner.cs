using WindowsFormsApplication1.Entities;
using WindowsFormsApplication1.Interfaces;

namespace WindowsFormsApplication1.Implementations.RuleRunners
{
    public class JavascriptRuleRunner : IRuleRunner
    {
        public RuleLanguage RuleLanguage { get { return RuleLanguage.JavaScript; } }
        public bool RunRule(string content)
        {
            return new Jurassic.ScriptEngine().Evaluate<bool>(content);
        }
    }
}