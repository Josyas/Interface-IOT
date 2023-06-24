using Microsoft.Data.Sqlite;
using MySql.Data.MySqlClient;

namespace Interface.ConexaoDB
{
    public class AppDbContext
    {
        public SqliteConnection PegarConexao()
        {
            const string dbPath = @"C:\Users\Usuario\Desktop\sqliteDb\logs.db";
            const string conncetionString = "Data Source=" + dbPath;

            SqliteConnection sqlConnection = new(conncetionString);
            sqlConnection.Open();

            return sqlConnection;
        }

        public void FecharConexao()
        {
            SqliteConnection sqlConnection = new();

            sqlConnection.Close();
        }
    }
}
