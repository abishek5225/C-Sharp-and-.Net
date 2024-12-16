/*
14. Write a C# program to create table named employee with columns eid as int, name as
varchar, address as varchar and salary as double using ADO.Net. Insert 5 records and
perform following actions:
a. update name as Ram and salary as 55000 of employee whose eid is 102.
b. Write a C# program to delete record of employee whose eid is 104.
c. select records of employee whose address is Btm and salary is between 30000 to
40000 using connected architecture (Data Reader).
*/

using System;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cms;

class Program38{
    static void Main(){
        string server = "localhost";
        string database = "csharpdb";
        string username = "root";
        string password = " ";//enter your password
        string connectionString = $"Server={server};Database={database};Uid={username};Pwd={password};";

        using(MySqlConnection connection = new MySqlConnection(connectionString)){
            try{
                connection.Open();

                string createTableQuery = @"CREATE TABLE empleyee(
                                        eid INT PRIMARY KEY,
                                        name VARCHAR(50),
                                        address VARCHAR(50),
                                        salary FLOAT
                                        );";
                
                using(MySqlCommand cmd = new MySqlCommand(createTableQuery, connection)){
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Table employee created successfully.");
                }

                string insertQuery = @"INSERT INTO employee(eid, name, address, salary)VALUES
                                (101, 'Amit', 'Btm', 35000),
                                (102, 'Suresh', 'Jayanagar', 50000),
                                (103, 'Ramesh', 'Btm', 32000),
                                (104, 'Mahesh', 'Koramangala', 45000),
                                (105, 'Rajesh', 'Btm', 38000);";
                
                using(MySqlCommand cmd = new MySqlCommand(insertQuery, connection)){
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("5 records inserted successfully.");
                }

                string updateQuery = "UPDATE employee SET name= 'Ram', salary = 55000 WHERE eid=102;";
                using(MySqlCommand cmd = new MySqlCommand(updateQuery, connection)){
                    int rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine($"Updated {rowsAffected} record(s).");
                }

                string deleteQuery = "DELETE FROM employee WHERE eid=104;";
                using(MySqlCommand cmd = new MySqlCommand(deleteQuery, connection)){
                    int rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine($"Deleted {rowsAffected} record(s).");
                }

                string selectQuery = "SELECT * FROM employee WHERE address= 'Btm' AND salary BETWEEN 30000 AND 40000;";
                using(MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                using (MySqlDataReader reader = cmd.ExecuteReader()){
                    Console.WriteLine("\nRecords with address 'Btm' and salary between 30000 and 40000:");
                    Console.WriteLine("eid\tname\taddress\tsalary");
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["eid"]}\t{reader["name"]}\t{reader["address"]}\t{reader["salary"]}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
                Console.WriteLine("Connection closed.");
            }
        }
    }

}