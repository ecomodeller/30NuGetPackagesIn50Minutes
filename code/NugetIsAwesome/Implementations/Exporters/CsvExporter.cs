using System.IO;
using WindowsFormsApplication1.Entities;
using WindowsFormsApplication1.Interfaces;
using EnsureThat;

namespace WindowsFormsApplication1.Implementations.Exporters
{
    public class CsvExporter :IExporter
    {
        public ExportTargets Target { get { return ExportTargets.CSV;} }
        public void ExportRule(Rule rule, Stream outputStream)
        {
            Ensure.That(rule, "rule").IsNotNull();

            using (var writer = new StreamWriter(outputStream))
            {
                new CsvHelper.CsvWriter(writer).WriteRecords(new[] {rule});
                
                writer.Flush();
            }
        }
    }
}