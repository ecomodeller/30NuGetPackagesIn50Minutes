using System.Collections.Generic;
using WindowsFormsApplication1.Implementations.Actions;
using WindowsFormsApplication1.Implementations.DataAccess;
using WindowsFormsApplication1.Implementations.Exporters;
using WindowsFormsApplication1.Implementations.RuleRunners;
using WindowsFormsApplication1.Interfaces;

namespace WindowsFormsApplication1
{
    public static class Globals
    {
        public static IDataAccess DataAccess { get; private set; }
        public static FormActions FormActions { get; private set; }
        public static List<IRuleRunner> RuleRunners { get; private set; }
        public static List<IExporter> Exporters { get; private set; }
        public static List<IRuleAction> Actions { get; private set; }

        static Globals()
        {
            DataAccess = new MemoryDataAccess();
            FormActions = new FormActions();
            RuleRunners = new List<IRuleRunner>() {new CSharpRuleRunner(), new JavascriptRuleRunner(), new PythonRuleRunner(), new RubyRuleRunner(), new SchemeRuleRunner()};
            Exporters = new List<IExporter>() {new StringExporter(), new JsonExporter(), new IniExporter(), new CsvExporter(), new PdfExporter(), new ExcelExporter()};       
            Actions = new List<IRuleAction>() {new TextTemplateAction(), new VideoAction()};
        }
    }
}