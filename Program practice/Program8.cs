//Write a C# program to create and use namespace.

//creating

/*
using System;

namespace MyNamespace
{
    public class MyClass
    {
        public void SayHello()
        {
            Console.WriteLine("Hello from MyNamespace!");
        }
    }
}
*/
//using
/*
    using System;
using MyNamespace; // Import the custom namespace

class Program
{
    static void Main()
    {
        // Create an instance of MyClass from MyNamespace
        MyClass myClassInstance = new MyClass();
        
        // Call the SayHello method
        myClassInstance.SayHello();
    }
}

*/