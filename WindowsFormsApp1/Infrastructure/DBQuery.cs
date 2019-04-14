using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Infrastructure
{
    public class DBQuery
    {

        private readonly string _dataSource = @"DESKTOP-90E0LOH\SQLEXPRESS";
        private readonly string _initialCatalog = "Test";
        private readonly bool _integratedSecurity = true;
        private string _connString;
        
        public DBQuery()
        {
            _connString = $"Data Source={_dataSource};Initial Catalog={_initialCatalog};Integrated Security={_integratedSecurity}";
        }

        public DBQuery(string connString)
        {
            _connString = connString;
        } 

        public DataTable GetData()
        {
            DataTable table = new DataTable();

            using (SqlConnection sqlConn = new SqlConnection(_connString))
            {
                string sqlQuery = @"SELECT * FROM Account";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlConn))
                {
                    SqlDataAdapter ds = new SqlDataAdapter(cmd);
                    ds.Fill(table);
                }
            }

            return table;
        }




    }
}
