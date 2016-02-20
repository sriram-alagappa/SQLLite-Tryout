using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLLite_Tryout
{
    class Program
    {
      

        static void Main(string[] args)
        {


            new SQLLiteTest();



        }
    }
    
    class SQLLiteTest
    {
      

        System.Data.SQLite.SQLiteConnection m_dbConnection;
        public SQLLiteTest()
        {
            SQLiteConnection.CreateFile("MyDatabase.sqlite");
            m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            m_dbConnection.Open();

            string sql = "create table employees (name varchar(20) )";

            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

        }
    }
}
