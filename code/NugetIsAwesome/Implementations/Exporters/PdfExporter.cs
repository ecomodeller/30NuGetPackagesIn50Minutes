using System;
using System.IO;
using WindowsFormsApplication1.Entities;
using WindowsFormsApplication1.Interfaces;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace WindowsFormsApplication1.Implementations.Exporters
{
    public class PdfExporter : IExporter
    {
        public ExportTargets Target { get {return ExportTargets.PDF;} }
        public void ExportRule(Rule rule, Stream outputStream)
        {
            Document doc = new Document();
            var writer = PdfWriter.GetInstance(doc, outputStream);

            doc.Open();            
            doc.Add(Paragraph.GetInstance(GetRuleAsString(rule)));

            doc.Close();
        }

        private string GetRuleAsString(Rule rule)
        {
            return
                string.Format(
                    "Name: {1}{0}Content:{0}-----------------{0}{2}{0}-----------------{0}Language: {3}{0}Schedule: {4}{0}Action: {5}{0}Action value: {0}-----------------{0}{6}{0}-----------------",
                    Environment.NewLine,
                    rule.Name, rule.Content, rule.RuleLanguage, rule.Schedule.ToString("dd/MM/yyyy hh:mm"), rule.Action,
                    rule.ActionValue);
        }
    }
}