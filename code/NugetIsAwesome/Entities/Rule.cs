using System;

namespace WindowsFormsApplication1.Entities
{
    public class Rule
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public RuleLanguage RuleLanguage { get; set; }
        public DateTime Schedule { get; set; }
        public RuleAction Action { get; set; }
        public string ActionValue { get; set; }
    }
}