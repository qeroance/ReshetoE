using System.Data.SQLite;
using System.Data;
using System;
using System.Security.Cryptography;
using System.Text;

namespace ReshetoE
{
    public class Database
    {
        public string Hash(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }
        private readonly string dataSource;
        public Database(string dataSource)
        {
            InitializeDatabase();
            this.dataSource = dataSource;
        }
        public bool InitializeDatabase()
        {
            SQLiteConnection conn = new SQLiteConnection(dataSource);
            try
            {
                conn.Open();
                SQLiteCommand cmd = conn.CreateCommand();
                string sql_command = "DROP TABLE IF EXISTS users;"
                + "CREATE TABLE users("
                + "id INTEGER PRIMARY KEY AUTOINCREMENT, "
                + "login TEXT, "
                + "password TEXT)";

                cmd.CommandText = sql_command;
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Dispose();
            }
            return true;
        }
        public bool ValidUser(string username, string password)
        {
            SQLiteConnection conn = new SQLiteConnection(dataSource);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("SELECT COUNT(*) "
                + "FROM users "
                + "where login = '{0}' AND "
                + "password = '{1}'",
               username, password);
                var usersCount = Convert.ToInt32(cmd.ExecuteScalar());
                return usersCount > 0;
            }
            return false;
        }
        public bool Checklogin(string username)
        {
            SQLiteConnection conn = new SQLiteConnection(dataSource);
            conn.Open();
            
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("SELECT COUNT(*) "
                + "FROM users "
                + "where login = '{0}'", username);
                var usersCount = Convert.ToInt32(cmd.ExecuteScalar());
                return usersCount > 0;

        }
        public bool CreateUser(string username, string password)
        {
            SQLiteConnection conn = new SQLiteConnection(dataSource);

            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("INSERT INTO users (login, password)"
                + "VALUES ('{0}', '{1}')",
                username, password);
                cmd.ExecuteNonQuery();
                return true;
            }
            return true;
        }
    }
}
