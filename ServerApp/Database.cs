using Microsoft.Data.Sqlite;
using System;

namespace ServerApp
{
    internal static class Database
    {
        private static readonly string connString = "Data Source=user_data.db";

        public static void Initialize()
        {
            using (var conn = new SqliteConnection(connString))
            {
                conn.Open();
                string sql = @"
                    CREATE TABLE IF NOT EXISTS Users (
                        UserId INTEGER PRIMARY KEY AUTOINCREMENT,
                        Username TEXT NOT NULL UNIQUE,
                        Password TEXT NOT NULL,
                        Email TEXT,
                        FullName TEXT,
                        Birthday TEXT
                    );";

                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
        }
    }
}
