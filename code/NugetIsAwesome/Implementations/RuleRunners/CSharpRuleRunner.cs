using System;
using WindowsFormsApplication1.Entities;
using WindowsFormsApplication1.Interfaces;

namespace WindowsFormsApplication1.Implementations.RuleRunners
{
    public class CSharpRuleRunner : IRuleRunner
    {
        public RuleLanguage RuleLanguage { get {return RuleLanguage.CSharp;} }
        public bool RunRule(string content)
        {
            var engine = new Roslyn.Scripting.CSharp.ScriptEngine();
            engine.AddReference(typeof(Console).Assembly);
            var session = engine.CreateSession();
            session.Execute("public bool Run() {" + content + "}");
            return session.Execute<bool>("Run()");
        }
    }
}