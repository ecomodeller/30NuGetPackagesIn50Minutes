using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Entities;
using FluentDateTime;
using GeorgeCloney;
using Humanizer;
using SeeShahp;

namespace WindowsFormsApplication1
{
    public partial class CreateRule : Form
    {
        public CreateRule()
        {
            Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

            InitializeComponent();

            comboLanguage.DataSource = Enum.GetNames(typeof(RuleLanguage)).Select(str => str.Humanize()).ToList();            
            comboActions.DataSource = Enum.GetNames(typeof(RuleAction)).Select(str => str.Humanize()).ToList();
            foreach (var exportTarget in Enum.GetValues(typeof (ExportTargets)))
            {
                menuExport.Items.Add(new ToolStripMenuItem(exportTarget.ToString().Humanize()) { Tag = exportTarget });
            }
            
            btnExport.Click += (s, e) => menuExport.Show(btnExport, new Point(Cursor.HotSpot.X, Cursor.HotSpot.Y + btnExport.Height));
            menuExport.ItemClicked += (s, e) =>
            {
                menuExport.Close();
                Globals.FormActions.ExportRule(GetRule(), (ExportTargets) e.ClickedItem.Tag);
                MessageBox.Show("Done!", "Export is Done", MessageBoxButtons.OK);
            };

            dateSchedule.Value = 3.Minutes().FromNow();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Globals.DataAccess.SaveRule(GetRule());
  
            Close();
        }

        public void SetRule(Entities.Rule rule)
        {
            tbName.Text = rule.Name;
            tbRule.Text = rule.Content;
            comboLanguage.Text = rule.RuleLanguage.Humanize();
            dateSchedule.Value = rule.Schedule;
            comboActions.Text = rule.Action.Humanize();
            tbActionValue.Text = rule.ActionValue;
        }

        private Rule GetRule()
        {
            return new Entities.Rule
            {
                Name = tbName.Text,
                Content = tbRule.Text,
                RuleLanguage = (RuleLanguage) comboLanguage.Text.DehumanizeTo<RuleLanguage>(),
                Schedule = dateSchedule.Value,
                Action = (RuleAction) comboActions.Text.DehumanizeTo<RuleAction>(),
                ActionValue = tbActionValue.Text
            };
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            var rule = GetRule();
            var result = Globals.FormActions.RunRule(rule);
            MessageBox.Show("Result from running rule: " + result + (result? ". Now going to run action." :""), "Rule Result",
                MessageBoxButtons.OK);

            if (result)
            {
                Globals.FormActions.RunRuleAction(rule);
            }
        }

        private void btnClone_Click(object sender, EventArgs e)
        {
            Rule rule = GetRule().DeepClone();
            rule.Name += " (Cloned)";

            Globals.DataAccess.SaveRule(rule);
            Close();
        }

        private void btnLol_Click(object sender, EventArgs e)
        {
            tbActionValue.Text = LOLSPEAK.GIMIE(tbActionValue.Text);
        }
    }
}
