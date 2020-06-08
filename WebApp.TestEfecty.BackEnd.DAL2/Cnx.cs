using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace WebApp.TestEfecty.BackEnd.DAL
{
    class Cnx
    {
        SqlConnection sqlConnection;
        SqlCommand command;
        public Cnx() {
        }

        public DataTable ExecuteReader(string cmdText) {
            SqlDataReader dataReader;
            DataTable dataTable = new DataTable();
            using (sqlConnection = new SqlConnection("Data Source=(local);Initial Catalog=Test_EfectyGML;Integrated Security=True"))
            {
                //try
                //{
                sqlConnection.Open();
                command = new SqlCommand(cmdText, sqlConnection);
                dataReader = command.ExecuteReader();
                dataTable.Load(dataReader);
                dataReader.Close();
                command.Dispose();
                sqlConnection.Close();
                //}
                //catch { }
            }
            return dataTable;
        }

        public int Execute(string cmdText)
        {
            int affected;
            using (sqlConnection = new SqlConnection("Data Source=(local);Initial Catalog=Test_EfectyGML;Integrated Security=True"))
            {
                //try
                //{
                sqlConnection.Open();
                command = new SqlCommand(cmdText, sqlConnection);
                affected = command.ExecuteNonQuery();
                command.Dispose();
                sqlConnection.Close();
                //}
                //catch { }
            }
            return affected;
        }
    }
}
