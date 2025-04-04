﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetExample
{
    public class AdonetUtility
    {
        private readonly string _connectionString = "Server=DESKTOP-5IJV2CO\\SQLEXPRESS;Database=AdoNetExample;User Id=adonetexample;Password=123456;Trust Server Certificate=True;";
        public void RunSql(string sql, Dictionary<string, object> parameters)
        {
            using SqlConnection sqlConnection = new SqlConnection(_connectionString);
            using SqlCommand cmd = new SqlCommand(sql, sqlConnection);

            foreach (var parameter in parameters) {
                cmd.Parameters.Add(new SqlParameter(parameter.Key, parameter.Value));
            }

            if(sqlConnection.State != System.Data.ConnectionState.Open)
                sqlConnection.Open();

            int rowExpected = cmd.ExecuteNonQuery();   // It return integer that how row effected into database.
        }

        public List<Dictionary<string, object>> GetData(string sql, Dictionary<string, object> parameters)
        {
            using SqlConnection sqlConnection = new SqlConnection(_connectionString);
            using SqlCommand cmd = new SqlCommand(sql, sqlConnection);

            foreach (var parameter in parameters)
            {
                cmd.Parameters.Add(new SqlParameter(parameter.Key, parameter.Value));
            }

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
                //int id = (int)reader["id"];
                //string name = (string)reader["name"];
                //DateTime dateofbirth = (DateTime)reader["dateofbirth"];
                //bool ismarried = (bool)reader["ismarried"];
                result.Add(row);
            }
            return result;
        }
    }
}
