using System.IO;
using WindowsFormsApplication1.Entities;
using WindowsFormsApplication1.Interfaces;
using IniParser;

namespace WindowsFormsApplication1.Implementations.Exporters
{
    public class IniExporter : IExporter
    {
        public ExportTargets Target { get { return ExportTargets.Ini; } }
        public void ExportRule(Rule rule, Stream outputStream)
        {
            using (var writer = new StreamWriter(outputStream))
            {
                new IniParser.StreamIniDataParser().WriteData(writer, ConvertRuleToIniData(rule));
                writer.Flush();
            }
        }

        private IniData ConvertRuleToIniData(Rule rule)
        {
            var data = new IniData();

            data.Sections = new SectionDataCollection();
            data.Sections.AddSection("rule");
            var section = data.Sections["rule"];
            section.AddKey("name", rule.Name);
            section.AddKey("content", rule.Content);
            section.AddKey("language", rule.RuleLanguage.ToString());
            section.AddKey("schedule", rule.Schedule.ToString("dd/MM/yyyy hh:mm"));
            section.AddKey("action", rule.Action.ToString());
            section.AddKey("action-value", rule.ActionValue);

            return data;
        }
    }
}