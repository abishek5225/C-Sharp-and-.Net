//practice for custom exception
/*

using System;

class Customexception : Exception{
    public Customexception (string message) : base(message){
    }
}
class Program45{
    static void Main(){
    try{
        Console.WriteLine("Enter age:");
        int age = int.Parse(Console.ReadLine());
        if(age < 18){
            throw new Customexception("You are not eligible to vote");
        }
        else{
            Console.WriteLine("You are eligible to vote");
        }
    }catch(Exception e){
        Console.WriteLine(e.Message);
    }finally{
        Console.WriteLine("Thank you for using our service");
    }
}
}
*/