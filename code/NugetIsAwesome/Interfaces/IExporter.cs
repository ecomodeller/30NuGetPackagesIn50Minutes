using System.IO;
using WindowsFormsApplication1.Entities;

namespace WindowsFormsApplication1.Interfaces
{
    public interface IExporter
    {
        ExportTargets Target { get; }

        void ExportRule(Rule rule, Stream outputStream);
    }
}