//LINQ with List
/*
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
class Program2 {
    static void Main(){


        List<Person> people = new List<Person>{
            new Person{ Name = "John", Age = 21 },
            new Person{ Name = "Jane", Age = 30 },
            new Person{ Name = "Jim", Age = 35 },
            new Person{Name= "Abishek", Age=22}
        };
        var adults = from p in people
        where p.Age>25
        select p;


        Console.WriteLine("People older than 25");
        foreach(var result in adults){
            Console.WriteLine($"{result.Name}, {result.Age}");
        }
    }
}
*/