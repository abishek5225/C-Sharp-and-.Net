class Employee{
    public string Name{get;set;}
    public int Age{get; set;}
    public string Address{get; set;}
}
class Program48{
    static void Main(){
        List<Employee> employees = new List<Employee> {
            new Employee{Name="John", Age=25, Address="USA"},
            new Employee{Name="Smith", Age=30, Address="UK"},
            new Employee{Name="David", Age=35, Address="USA"},
            new Employee{Name="Sam", Age=40, Address="Australia"}
        };
        var addressUSA = employees.Where(e => e.Address == "USA");
        foreach(var container in addressUSA){
            Console.WriteLine(container.Name + " " + container.Age + " " + container.Address);
        }
    }
}