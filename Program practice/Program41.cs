/*
Write a C# program to show insert and select operations in a database.
*/
/*
using System;
using MySql.Data.MySqlClient;

class Program41{
    static void Main(){
        string connectionString = "server= localhost; user=root; password=12345; database=csharpdb";

        InsertEmployee(connectionString, "Ram", 30000.00m, "kathmandu");
        InsertEmployee(connectionString, "Shyam", 40000.00m, "Pokhara");

        SelectEmployees(connectionString);
    }
    static void InsertEmployee(string connectionString, string name, decimal salary, string address){
        try{
            using(MySqlConnection connection = new MySqlConnection(connectionString)){

                connection.Open();

                string query = "INSERT INTO employees (name, salary, address) VALUES (@name, @salary, @address)";
                using(MySqlCommand cmd = new MySqlCommand(query, connection)){
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@salary", salary);
                    cmd.Parameters.AddWithValue("@address", address);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine($"Inserted {rowsAffected} row(s) successfully.");
                }
            }
        }catch(Exception ex){
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void SelectEmployees(string connectionString){
        try{
            using(MySqlConnection connection = new MySqlConnection(connectionString)){
                connection.Open();
                string query = "SELECT id, name, salary, address FROM employees";
                using(MySqlCommand cmd = new MySqlCommand(query, connection)){
                    using(MySqlDataReader reader = cmd.ExecuteReader()){
                        while(reader.Read()){
                            Console.WriteLine($"ID: {reader["id"]}, Name: {reader["name"]}, Salary: {reader["salary"]}, Address: {reader["address"]}");
                        }
                    }
                }
            }
        }catch(Exception ex){
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
*/