using WindowsFormsApplication1.Entities;

namespace WindowsFormsApplication1.Interfaces
{
    public interface IRuleRunner
    {
        RuleLanguage RuleLanguage { get; }
        bool RunRule(string content);
    }
}