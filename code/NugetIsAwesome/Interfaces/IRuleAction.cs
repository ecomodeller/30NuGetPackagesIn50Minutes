using System;
using WindowsFormsApplication1.Entities;

namespace WindowsFormsApplication1.Interfaces
{
    public interface IRuleAction
    {
        RuleAction Action { get; }

        void ExecuteAction(string value);
    }
}