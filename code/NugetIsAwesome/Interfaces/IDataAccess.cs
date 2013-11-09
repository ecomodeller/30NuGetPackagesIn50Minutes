using System.Collections.Generic;
using WindowsFormsApplication1.Entities;

namespace WindowsFormsApplication1.Interfaces
{
    public interface IDataAccess
    {
        ICollection<Rule> GetRules();
        void SaveRule(Rule rule);
    }
}