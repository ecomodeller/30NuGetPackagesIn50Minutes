using System;
using System.Windows.Forms;
using WindowsFormsApplication1.Entities;
using WindowsFormsApplication1.Interfaces;
using RazorTemplates.Core;

namespace WindowsFormsApplication1.Implementations.Actions
{
    public class TextTemplateAction : IRuleAction
    {
        public RuleAction Action { get {return RuleAction.Text; } }
        public void ExecuteAction(string value)
        {
            MessageBox.Show(Template.Compile(value).Render(new {}), "Text Action Result", MessageBoxButtons.OK);
        }
    }
}