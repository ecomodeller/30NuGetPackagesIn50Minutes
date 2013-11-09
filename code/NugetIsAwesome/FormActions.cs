using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApplication1.Entities;
using Ionic.Zip;
using IronPython.Modules;

namespace WindowsFormsApplication1
{
    public class FormActions
    {
        public bool RunRule(Rule rule)
        {
            return Globals.RuleRunners.First(
                runner =>
                    runner.RuleLanguage == rule.RuleLanguage).RunRule(rule.Content);
        }

        public void RunRuleAction(Rule rule)
        {
            Globals.Actions.First(action => action.Action == rule.Action).ExecuteAction(rule.ActionValue);
        }

        public void ExportRule(Rule rule, ExportTargets target)
        {
            var dialog = new SaveFileDialog();

            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            using (var stream = new FileStream(dialog.FileName, FileMode.Create, FileAccess.ReadWrite))
            {
                Globals.Exporters.First(e => e.Target == target).ExportRule(rule, stream);
            }
        }

        public void ExportRules(List<Rule> rules)
        {
            var dialog = new SaveFileDialog {DefaultExt = "zip"};

            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            using (var zipFile = new ZipFile())
            {
                var exporter = Globals.Exporters.First(e => e.Target == ExportTargets.String);

                foreach (var rule in rules)
                {
                    var stream = new MemoryStream();
                    exporter.ExportRule(rule, stream);
                    zipFile.AddEntry(rule.Name + ".txt", stream.ToArray());                                            
                }
                
                zipFile.Save(dialog.FileName);
            }
        }
    }
}