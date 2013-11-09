using System.Collections.Generic;
using WindowsFormsApplication1.Entities;
using WindowsFormsApplication1.Interfaces;

namespace WindowsFormsApplication1.Implementations.DataAccess
{
    public class MemoryDataAccess : IDataAccess
    {
        private List<Rule> _rules;

        public MemoryDataAccess()
        {
            _rules = new List<Rule>();
        }

        public ICollection<Rule> GetRules()
        {
            return _rules;
        }

        public void SaveRule(Rule rule)
        {
            _rules.Add(rule);
        }
    }
}