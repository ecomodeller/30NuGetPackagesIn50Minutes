using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Entities;
using Humanizer;
using Microsoft.Scripting.Utils;
using NCalc;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

            InitializeComponent();

            foreach (var exportTarget in Enum.GetNames(typeof(ExportTargets)).Select(str => str.Humanize()))
            {
                menuExport.Items.Add(exportTarget);
            }

            //btnExport.Click += (s, e) => menuExport.Show(btnExport, new Point(Cursor.HotSpot.X, Cursor.HotSpot.Y + btnExport.Height));

            RefreshRuleList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ShowRuleDialog();
        }

        private void RefreshRuleList()
        {
            lvRules.Items.Clear();
            lvRules.Items.AddRange(Globals.DataAccess.GetRules().Select(rule => new ListViewItem(rule.Name) {Tag = rule }).ToArray());

            lblRuleCount.Text = lvRules.Items.Count + " ";
            if (lvRules.Items.Count != 1)
            {
                lblRuleCount.Text += "rule".Pluralize();
            }
            else
            {
                lblRuleCount.Text += "rule";
            }
        }

        private void ShowRuleDialog(Entities.Rule rule = null)
        {
            CreateRule ruleDialog = new CreateRule();

            if (rule != null)
            {
                ruleDialog.SetRule(rule);
            }

            ruleDialog.ShowDialog();

            RefreshRuleList();
        }

        private void lvRules_DoubleClick(object sender, EventArgs e)
        {
            if (lvRules.SelectedItems.Count != 1)
            {
                return;
            }

            ShowRuleDialog(lvRules.SelectedItems[0].Tag as Entities.Rule);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Globals.FormActions.ExportRules(lvRules.SelectedItems.Select(item => (Entities.Rule)((ListViewItem)item).Tag).ToList());

            MessageBox.Show("Done exporting to zip!", "Done!", MessageBoxButtons.OK);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Answer: " + new Expression(tbCalc.Text).Evaluate(), "THE ANSWER IS...",
                MessageBoxButtons.OK);
        }
    }
}
