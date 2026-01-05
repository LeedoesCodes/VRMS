using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace VRMS.Database
{
    public static class DB
    {
        private static string? _connectionString;

        public static void Initialize(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new InvalidOperationException("Database connection string is missing.");

            _connectionString = connectionString;
        }

        private static MySqlConnection GetConnection()
        {
            if (_connectionString == null)
                throw new InvalidOperationException("DB.Initialize() was not called.");

            return new MySqlConnection(_connectionString);
        }

        public static void ExecuteNonQuery(string sql)
        {
            using var conn = GetConnection();
            using var cmd = new MySqlCommand(sql, conn);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public static object? ExecuteScalar(string sql)
        {
            using var conn = GetConnection();
            using var cmd = new MySqlCommand(sql, conn);

            conn.Open();
            return cmd.ExecuteScalar();
        }

        public static DataTable ExecuteQuery(string sql)
        {
            using var conn = GetConnection();
            using var cmd = new MySqlCommand(sql, conn);
            using var adapter = new MySqlDataAdapter(cmd);

            var table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}