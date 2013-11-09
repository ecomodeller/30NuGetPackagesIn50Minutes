using WindowsFormsApplication1.Entities;
using WindowsFormsApplication1.Interfaces;

namespace WindowsFormsApplication1.Implementations.RuleRunners
{
    public class RubyRuleRunner : IRuleRunner
    {
        public RuleLanguage RuleLanguage { get { return RuleLanguage.Ruby; } }
        public bool RunRule(string content)
        {
            return IronRuby.Ruby.CreateEngine().Execute<bool>(content);
        }
    }
}