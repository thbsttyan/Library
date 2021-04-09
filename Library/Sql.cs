using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Sql
    {
        SqlConnection connection;
        string connectionStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=Library; Integrated Security=true;";

        public Sql()
        {
            ConnectToDB();
        }

        void ConnectToDB()
        {
            connection = new SqlConnection(connectionStr);
            connection.Open();
        }

        public DataTable Select(string request)
        {

            SqlCommand command = new SqlCommand(request, connection);
            SqlDataReader reader = command.ExecuteReader();

            DataTable res = new DataTable();

            if (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                    res.Columns.Add(reader.GetName(i), reader.GetFieldType(i));
                res.Rows.Add();
                for (int i = 0; i < reader.FieldCount; i++)
                    res.Rows[res.Rows.Count - 1][i] = reader[i];
            }

            while (reader.Read())
            {
                res.Rows.Add();
                for (int i = 0; i < reader.FieldCount; i++)
                    res.Rows[res.Rows.Count - 1][i] = reader[i];
            }

            reader.Close();
            return res;
        }
        public DataTable SelectTable(string name, string searchType, string searchValue)
        {
            if (name == "") return new DataTable();

            SqlCommand command = new SqlCommand($"select * from {name} where {searchType} like {searchValue}", connection);
            SqlDataReader reader = command.ExecuteReader();
                
            DataTable res = new DataTable();

            if (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                    res.Columns.Add(reader.GetName(i), reader.GetFieldType(i));
                res.Rows.Add();
                for (int i = 0; i < reader.FieldCount; i++)
                    res.Rows[res.Rows.Count - 1][i] = reader[i];
            }

            while (reader.Read())
            {
                res.Rows.Add();
                for (int i = 0; i < reader.FieldCount; i++)
                    res.Rows[res.Rows.Count - 1][i] = reader[i];
            }

            reader.Close();
            return res;
        }
    }
}
