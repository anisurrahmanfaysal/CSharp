﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetPractice
{
    public class AdonetUtility
    {
        private readonly string _connectionString = "Server=DESKTOP-5IJV2CO\\SQLEXPRESS;Database=AdoNetPractice;User Id=adonetpractice;Password=123456;Trust Server Certificate=True;";
        public void SqlRun(string sql)
        {
            SqlConnection sqlConnection = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);

            if (sqlConnection.State != System.Data.ConnectionState.Open)
                sqlConnection.Open();
            

            int rowExpected = cmd.ExecuteNonQuery();  // It return integer that how row effected into database.
            sqlConnection.Close();
            sqlConnection.Dispose();
            cmd.Dispose();
        }

        public List<Dictionary<string, object>> GetData(string sql)
        {
            SqlConnection sqlConnection = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);

            if (sqlConnection.State != System.Data.ConnectionState.Open)
                sqlConnection.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();
            while (reader.Read())
            {
                Dictionary<string, object> row = new Dictionary<string, object>();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    string columnName = reader.GetName(i);
                    object columnValue = reader.GetValue(i);
                    row.Add(columnName, columnValue);
                }
                result.Add(row);
            }
            return result;
        }
    }
}
