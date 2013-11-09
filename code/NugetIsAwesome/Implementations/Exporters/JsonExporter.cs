using System.IO;
using WindowsFormsApplication1.Entities;
using WindowsFormsApplication1.Interfaces;
using Newtonsoft.Json;

namespace WindowsFormsApplication1.Implementations.Exporters
{
    public class JsonExporter :IExporter
    {
        public ExportTargets Target { get {return ExportTargets.Json;} }
        public void ExportRule(Rule rule, Stream outputStream)
        {
            string output = JsonConvert.SerializeObject(rule);
            using (var writer = new StreamWriter(outputStream))
            {
                writer.Write(output);
                writer.Flush();
            }
        }
    }
}