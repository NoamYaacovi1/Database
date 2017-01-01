using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Database_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C: \\Users\\Bar\\Documents\\GitHub\\Database\\Database Ex\\Database Ex\\Database1.mdf\";Integrated Security=True";
            SqlConnection conn = new SqlConnection(s);
            conn.Open();

            /**/SqlCommand createTableCommand = new SqlCommand();
            createTableCommand.Connection = conn;
            createTableCommand.CommandText = "CREATE TABLE songs (Singer varchar(255), name varchar(255), year int);";
            createTableCommand.ExecuteNonQuery();

            conn.Close();
        }
    }
}
