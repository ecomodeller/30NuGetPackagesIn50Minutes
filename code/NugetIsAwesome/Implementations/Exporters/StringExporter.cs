using System.IO;
using WindowsFormsApplication1.Entities;
using WindowsFormsApplication1.Interfaces;
using ObjectDumper;

namespace WindowsFormsApplication1.Implementations.Exporters
{
    public class StringExporter : IExporter
    {
        public ExportTargets Target { get { return ExportTargets.String; } }
        public void ExportRule(Rule rule, Stream outputStream)
        {
            using (var writer = new StreamWriter(outputStream))
            {
                rule.Dump("rule", writer);
                writer.Flush();
            }            
        }
    }
}