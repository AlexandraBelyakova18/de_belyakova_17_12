using System;
using System.Collections.Generic;
using System.Data.SQLite; // Не забудьте добавить ссылку на System.Data.SQLite
using System.IO;

namespace WindowsFormsApp4
{
    public class RepairRequest
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }

    public class DatabaseHelper
    {
        private string connectionString;

        public DatabaseHelper(string dbPath)
        {
            // Проверяем, существует ли база данных, и если нет, создаем ее
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
                CreateTable();
            }
            connectionString = $"Data Source={dbPath};Version=3;";
        }

        private void CreateTable()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string createTableQuery = @"
                    CREATE TABLE RepairRequests (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Description TEXT NOT NULL,
                        Status TEXT NOT NULL
                    )";
                using (SQLiteCommand command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        // Получить все заявки
        public List<RepairRequest> GetAllRequests()
        {
            var requests = new List<RepairRequest>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = "SELECT Id, Description, Status FROM RepairRequests";
                SQLiteCommand command = new SQLiteCommand(query, connection);

                connection.Open();
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        requests.Add(new RepairRequest
                        {
                            Id = reader.GetInt32(0),
                            Description = reader.GetString(1),
                            Status = reader.GetString(2)
                        });
                    }
                }
            }

            return requests;
        }

        // Добавить новую заявку
        public void AddRequest(RepairRequest request)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = "INSERT INTO RepairRequests (Description, Status) VALUES (@Description, @Status)";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Description", request.Description);
                command.Parameters.AddWithValue("@Status", request.Status);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Обновить существующую заявку
        public void UpdateRequest(RepairRequest request)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = "UPDATE RepairRequests SET Description = @Description, Status = @Status WHERE Id = @Id";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Id", request.Id);
                command.Parameters.AddWithValue("@Description", request.Description);
                command.Parameters.AddWithValue("@Status", request.Status);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Удалить заявку
        public void DeleteRequest(int id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = "DELETE FROM RepairRequests WHERE Id = @Id";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
