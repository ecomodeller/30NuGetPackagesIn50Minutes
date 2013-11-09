using WindowsFormsApplication1.Entities;
using WindowsFormsApplication1.Interfaces;

namespace WindowsFormsApplication1.Implementations.RuleRunners
{
    public class PythonRuleRunner : IRuleRunner
    {
        public RuleLanguage RuleLanguage { get { return RuleLanguage.Python; } }
        public bool RunRule(string content)
        {
            return IronPython.Hosting.Python.CreateEngine().Execute<bool>(content);
        }
    }
}