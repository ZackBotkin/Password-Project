﻿using System;
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

        private string connString = @"Data Source=DESKTOP-90E0LOH\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True";


        public DataTable GetData()
        {
            DataTable table = new DataTable();

            using (SqlConnection sqlConn = new SqlConnection(connString))
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
