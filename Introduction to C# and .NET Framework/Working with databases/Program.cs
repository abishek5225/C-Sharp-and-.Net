using System;
using MySql.Data.MySqlClient;

namespace Databaseswork
{
    class Program
    {
        static void Main()
        {
            string server = "localhost";
            string database = "csharpdb";
            string username = "root";
            string password = " ";//enter your password
            string connectionString = $"Server={server};Database={database};Uid={username};Pwd={password};";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection successful!");

                    // Corrected SQL query
                    string createTableQuery = @"CREATE TABLE IF NOT EXISTS users (
                                                id INT AUTO_INCREMENT PRIMARY KEY,
                                                name VARCHAR(50),
                                                email VARCHAR(50)
                                                );";

                    MySqlCommand createTableCmd = new MySqlCommand(createTableQuery, connection);
                    createTableCmd.ExecuteNonQuery();
                    Console.WriteLine("Table created successfully!");

                    // Insert data
                    string insertDataQuery = "INSERT INTO users (name, email) VALUES ('Abishek', 'abishek@gmail.com');";
                    MySqlCommand insertCmd = new MySqlCommand(insertDataQuery, connection);
                    insertCmd.ExecuteNonQuery();
                    Console.WriteLine("Data inserted into users table.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
