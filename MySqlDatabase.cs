using System;
using MySql.Data.MySqlClient;

namespace ceaweb
{
    public class MySqlDatabase : IDisposable
    {
       public MySqlConnection Connection { get; set; }

        public MySqlDatabase(string connectionString)
        {
            Connection = new MySqlConnection(connectionString);
            Connection.Open();
        }
        public void Dispose()
        {
            Connection.Close();
        }
    }
}
