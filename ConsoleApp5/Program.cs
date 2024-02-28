using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataBase db = new DataBase();
            db.GetConnection().Open();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
    class DataBase
    {
        public SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\vstud\ConsoleApp5\ConsoleApp5\Database1.mdf;Integrated Security=True");

        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }

    }
}
