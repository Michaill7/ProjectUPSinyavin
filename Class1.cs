using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjectUP
{
    public class SqlClass
    {
        public static DataTable SqlQuery(string query, SqlConnection connection)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return (table);
        }
    }
}
