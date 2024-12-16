/*
Write a C# program to store id, name, age, address and salary of 5 employees in a list.
Now write LINQ query for the following:
• Select name and age of employees whose salary is greater than 20000 and age is less
than 35.
• Select all records of employees whose name starts with letter ‘R’ and age greater than
25 in descending order based on age.
• Select all records of employee whose salary is maximum.
• Select id and name of employee whose salary is between 20000 and 30000.
• Select id and name of employees whose address is Btm and salary is greater than
average salary of employees.
• Select records of employee group by address in ascending order based on age.
*/
/*
using System;
using System.Collections.Generic;
using System.Linq;

// Define Employee class
class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
    public decimal Salary { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Create a list of employees
        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Ramesh", Age = 28, Address = "Btm", Salary = 25000 },
            new Employee { Id = 2, Name = "Suresh", Age = 32, Address = "Jayanagar", Salary = 18000 },
            new Employee { Id = 3, Name = "Rajesh", Age = 26, Address = "Btm", Salary = 22000 },
            new Employee { Id = 4, Name = "Rahul", Age = 36, Address = "Koramangala", Salary = 32000 },
            new Employee { Id = 5, Name = "Ravi", Age = 29, Address = "Btm", Salary = 27000 }
        };

        // LINQ Query 1: Select name and age of employees whose salary > 20000 and age < 35
        var query1 = employees.Where(e => e.Salary > 20000 && e.Age < 35)
                              .Select(e => new { e.Name, e.Age });
        Console.WriteLine("Employees with Salary > 20000 and Age < 35:");
        foreach (var emp in query1)
        {
            Console.WriteLine($"Name: {emp.Name}, Age: {emp.Age}");
        }
        Console.WriteLine();

        // LINQ Query 2: Select all records of employees whose name starts with 'R' and age > 25 in descending order of age
        var query2 = employees.Where(e => e.Name.StartsWith("R") && e.Age > 25)
                              .OrderByDescending(e => e.Age);
        Console.WriteLine("Employees whose Name starts with 'R' and Age > 25 (Descending order of Age):");
        foreach (var emp in query2)
        {
            Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Age: {emp.Age}, Address: {emp.Address}, Salary: {emp.Salary}");
        }
        Console.WriteLine();

        // LINQ Query 3: Select all records of the employee whose salary is maximum
        var maxSalary = employees.Max(e => e.Salary);
        var query3 = employees.Where(e => e.Salary == maxSalary);
        Console.WriteLine("Employee(s) with Maximum Salary:");
        foreach (var emp in query3)
        {
            Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Age: {emp.Age}, Address: {emp.Address}, Salary: {emp.Salary}");
        }
        Console.WriteLine();

        // LINQ Query 4: Select id and name of employees whose salary is between 20000 and 30000
        var query4 = employees.Where(e => e.Salary >= 20000 && e.Salary <= 30000)
                              .Select(e => new { e.Id, e.Name });
        Console.WriteLine("Employees with Salary between 20000 and 30000:");
        foreach (var emp in query4)
        {
            Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}");
        }
        Console.WriteLine();

        // LINQ Query 5: Select id and name of employees whose address is 'Btm' and salary > average salary
        var averageSalary = employees.Average(e => e.Salary);
        var query5 = employees.Where(e => e.Address == "Btm" && e.Salary > averageSalary)
                              .Select(e => new { e.Id, e.Name });
        Console.WriteLine("Employees in 'Btm' with Salary > Average Salary:");
        foreach (var emp in query5)
        {
            Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}");
        }
        Console.WriteLine();

        // LINQ Query 6: Group records of employees by address in ascending order of age
        var query6 = employees.GroupBy(e => e.Address)
                              .Select(group => new
                              {
                                  Address = group.Key,
                                  Employees = group.OrderBy(e => e.Age)
                              });
        Console.WriteLine("Employees Grouped by Address (Ascending order of Age):");
        foreach (var group in query6)
        {
            Console.WriteLine($"Address: {group.Address}");
            foreach (var emp in group.Employees)
            {
                Console.WriteLine($"  Id: {emp.Id}, Name: {emp.Name}, Age: {emp.Age}, Salary: {emp.Salary}");
            }
        }
    }
}
*/