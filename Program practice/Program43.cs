/*
Write a C# program to demonstrate multilevel and multiple inheritance.
*/

/*
class Person{
    public void DisplayPersonInfo(){
        Console.WriteLine("This is a person");
    }
}

class Employee : Person{
    public void DisplayEmployeeInfo(){
        Console.WriteLine("This is an employee");
    }
}

class Managaer : Employee{
    public void DisplayManagerInfo(){
        Console.WriteLine("This is a manager");
    }
}

interface IMan{
    void Man();
}

interface IWomen{
    void Women();
}

class Gender : Person,  IMan, IWomen{
    public void Man(){
        Console.WriteLine("This is a man");
    }
    public void Women(){
        Console.WriteLine("This is a woman");
    }
}

class Program43 {
    static void Main(string[] args) {
        Console.WriteLine("---Multilevel Inheritance---");
        Managaer obj=new Managaer();
        obj.DisplayPersonInfo();
        obj.DisplayEmployeeInfo();
        obj.DisplayManagerInfo();

        Console.WriteLine();

        Console.WriteLine("---Multiple Inheritance---");
        Gender obj1=new Gender();
        obj1.DisplayPersonInfo();
        obj1.Man();
        obj1.Women();
    }
}
*/