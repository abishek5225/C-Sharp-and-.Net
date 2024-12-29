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

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
    public double Salary { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee { Id = 1, Name = "Ravi", Age = 30, Address = "Btm", Salary = 25000 },
            new Employee { Id = 2, Name = "John", Age = 28, Address = "Indira Nagar", Salary = 18000 },
            new Employee { Id = 3, Name = "Rakesh", Age = 40, Address = "Btm", Salary = 32000 },
            new Employee { Id = 4, Name = "Raj", Age = 26, Address = "Btm", Salary = 29000 },
            new Employee { Id = 5, Name = "Rina", Age = 22, Address = "Koramangala", Salary = 22000 }
        };

        // Query 1: Select name and age of employees whose salary > 20000 and age < 35
        var query1 = employees
            .Where(e => e.Salary > 20000 && e.Age < 35)
            .Select(e => new { e.Name, e.Age });

        Console.WriteLine("Employees with salary > 20000 and age < 35:");
        foreach (var employee in query1)
        {
            Console.WriteLine($"Name: {employee.Name}, Age: {employee.Age}");
        }

        // Query 2: Select records of employees whose name starts with 'R' and age > 25, in descending order of age
        var query2 = employees
            .Where(e => e.Name.StartsWith("R") && e.Age > 25)
            .OrderByDescending(e => e.Age);

        Console.WriteLine("\nEmployees whose name starts with 'R' and age > 25 (Descending order by age):");
        foreach (var employee in query2)
        {
            Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Age: {employee.Age}, Address: {employee.Address}, Salary: {employee.Salary}");
        }

        // Query 3: Select the employee whose salary is maximum
        var query3 = employees
            .Where(e => e.Salary == employees.Max(emp => emp.Salary))
            .FirstOrDefault();

        Console.WriteLine("\nEmployee with the highest salary:");
        if (query3 != null)
        {
            Console.WriteLine($"Id: {query3.Id}, Name: {query3.Name}, Age: {query3.Age}, Address: {query3.Address}, Salary: {query3.Salary}");
        }

        // Query 4: Select id and name of employees whose salary is between 20000 and 30000
        var query4 = employees
            .Where(e => e.Salary >= 20000 && e.Salary <= 30000)
            .Select(e => new { e.Id, e.Name });

        Console.WriteLine("\nEmployees with salary between 20000 and 30000:");
        foreach (var employee in query4)
        {
            Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}");
        }

        // Query 5: Select id and name of employees whose address is 'Btm' and salary is greater than average salary
        double averageSalary = employees.Average(e => e.Salary);
        var query5 = employees
            .Where(e => e.Address == "Btm" && e.Salary > averageSalary)
            .Select(e => new { e.Id, e.Name });

        Console.WriteLine($"\nEmployees from 'Btm' with salary greater than average ({averageSalary}):");
        foreach (var employee in query5)
        {
            Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}");
        }

        // Query 6: Group employees by address and order by age in ascending order
        var query6 = employees
            .GroupBy(e => e.Address)
            .Select(g => new
            {
                Address = g.Key,
                Employees = g.OrderBy(e => e.Age)
            });

        Console.WriteLine("\nEmployees grouped by address and ordered by age:");
        foreach (var group in query6)
        {
            Console.WriteLine($"Address: {group.Address}");
            foreach (var employee in group.Employees)
            {
                Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Age: {employee.Age}, Salary: {employee.Salary}");
            }
        }
    }
}
*/