using System.IO;
using WindowsFormsApplication1.Entities;
using WindowsFormsApplication1.Interfaces;
using EnsureThat;
using OfficeOpenXml;

namespace WindowsFormsApplication1.Implementations.Exporters
{
    public class ExcelExporter : IExporter
    {
        public ExportTargets Target { get {return ExportTargets.Excel; } }

        public void ExportRule(Rule rule, Stream outputStream)
        {
            Ensure.That(rule, "rule").IsNotNull();

            var package = new ExcelPackage(outputStream);
            var worksheet = package.Workbook.Worksheets.Add("Rules");
            worksheet.Cells["B1"].Value = "Name";
            worksheet.Cells["C1"].Value = "Content";
            worksheet.Cells["D1"].Value = "Language";
            worksheet.Cells["E1"].Value = "Schedule";
            worksheet.Cells["F1"].Value = "Action";
            worksheet.Cells["G1"].Value = "Action Value";
            worksheet.Cells["B1:G1"].Style.Font.Bold = true;

            worksheet.Cells["B2"].Value = rule.Name;
            worksheet.Cells["C2"].Value = rule.Content;
            worksheet.Cells["D2"].Value = rule.RuleLanguage.ToString();
            worksheet.Cells["E2"].Value = rule.Schedule.ToString("dd/MM/yyyy hh:mm");
            worksheet.Cells["F2"].Value = rule.Action.ToString();
            worksheet.Cells["G2"].Value = rule.ActionValue;

            package.Save();            
        }
    }
}