using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetExample
{
    public class AdonetUtility
    {
        private readonly string _connectionString;
        public AdonetUtility()
        {
            _connectionString = "Server = DESKTOP-5IJV2CO\\SQLEXPRESS; Database = CSharpB18; User Id = csharpb18; Password = 123456;Trust Server Certificate=True";
        }
        public void RunSql(string sql)
        {
            SqlConnection sqlConnection = new SqlConnection(_connectionString);
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);

            if(sqlConnection.State != System.Data.ConnectionState.Open)
                sqlConnection.Open();

            int rowExpected = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            sqlConnection.Dispose();
            sqlCommand.Dispose();
        }

        public void GetData(string sql) {
            SqlConnection sqlConnection = new SqlConnection(_connectionString);
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);

            if (sqlConnection.State != System.Data.ConnectionState.Open)
                sqlConnection.Open();

            SqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read()) {

                for (int i = 0; i < reader.FieldCount; i++) 
                {
                    string columnName = reader.GetName(i);
                    object columnValue = reader.GetValue(i);

                }

                //int id = (int)reader["id"];
                //string name = (string)reader["name"];
                //DateTime dateofbirth = (DateTime)reader["dateofbirth"];
                //bool ismarried = (bool)reader["ismarried"];
            }
        }
    }
}
