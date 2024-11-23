using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetPractice
{
    public class AdonetUtility
    {
        private readonly string _connectionString;
        public AdonetUtility(string connectionString) 
        {
            _connectionString = connectionString;
        }

        public void RunSql(string sql)
        {
            SqlConnection sqlConnection = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);

            if(sqlConnection.State != System.Data.ConnectionState.Open)
                sqlConnection.Open();

            int rowExpected = cmd.ExecuteNonQuery();

            sqlConnection.Close();
            sqlConnection.Dispose();
            cmd.Dispose();
        }
    }
}
