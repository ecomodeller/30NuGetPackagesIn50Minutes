using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using WindowsFormsApplication1.Entities;
using WindowsFormsApplication1.Interfaces;
using DapperExtensions;

namespace WindowsFormsApplication1.Implementations.DataAccess
{
    public class DapperDataAccess :IDataAccess
    {
        private const string ConnectionString =
            "Data Source=.\\sqlexpress;Initial Catalog=RuleEngineFun;Integrated Security=True;Pooling=False";

        public ICollection<Rule> GetRules()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                var list = connection.GetList<Rule>();

                connection.Close();

                return list.ToList();
            }
        }

        public void SaveRule(Rule rule)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                connection.Insert(rule);

                connection.Close();
            }
        }
    }
}