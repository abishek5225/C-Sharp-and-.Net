/*
Write a program to select employees whose salary is greater than 20,000 and whose address is Kathmandu using LINQ.
*/

using System;
using System.Collections.Generic;
using System.Linq;
class Employee{
    public int ID {get; set;}
    public string Name {get; set;}
    public int Salary {get; set;}
    public string Address {get; set;}
}

class Program39{
    static void Main(){
        List<Employee> employees = new List<Employee>{
            new Employee {ID=1, Name="Abishek", Salary=100000, Address="dulabari"},
            new Employee {ID=2, Name="Arjun", Salary=20000, Address="prithivinagar"},
            new Employee {ID=3, Name="Binod", Salary= 20000, Address="butwal"},
            new Employee {ID=4, Name="Bishal", Salary=21000, Address="Kathmandu"},
            new Employee {ID=5, Name="Hemant", Salary=22000, Address="Kathmandu"}
        };

        var result = employees.Where(e => e.Salary > 20000 && e.Address.Equals("Kathmandu")).ToList();

        foreach(var container in result){
            Console.WriteLine(container.ID + " " + container.Name + " " + container.Salary + " "+ container.Address);
        }

    }
}