//WAP to create and throw your own custom exception.

/*
using System;

//We create a class named MyCustomException that inherits from System.Exception.
//It takes a message in its constructor, which is passed to the base Exception class.
public class MycustomException : Exception
{
    public MycustomException(string message) : base(message){

    }
}

class Program{
    static void Main(){
        try{
            validateAge(15); //calling a method that might throw the custom exception
        }catch(MycustomException e){
            Console.WriteLine(e.Message);
        }
    }
    //method to validate things if it doesnot meets the condition then the custom exception will be thrown to alert the user.
    //you can see in the program if user age is less then 18 then it display a message : "Age must be 18 or older"
    static void validateAge(int age){
        if(age<18){
            throw new MycustomException("Age must be 18 or older");
        }
        else{
            Console.WriteLine("Age is valid");
        }
    }
}

//now let's understand it
/*
i know that you guyz have been confused from 
the very first of the program haha....
here:-


public class MyCustomException : Exception
{
    public MyCustomException(string message) : base(message)
    {
    }
}


What’s happening here?
->MyCustomException is a new class that you are creating.
->This class represents a custom error that you define yourself.

# Inheriting from Exception:

-> (MyCustomException : Exception):
                   Exception means that MyCustomException
     is a childof the built-in exception class in C#.

-> Since exception is the base class for all errors in C#,
 this allows MyCustomException to behave like a regular error.

so what does built-in exception class in C# do?
->The exception class in C# is a built-in tool
 for handling errors. It represents problems in
  your program (like dividing by zero or missing files)
and provides useful details like an error message and location.
 It’s the base class for all errors and lets you catch and manage 
 issues using try-catch blocks.

 It will be easir to understand when you'll this program :-

 using System;

class Program
{
    static void Main()
    {
        try
        {
            int x = 5;
            int y = 0;
            Console.WriteLine(x / y); // This will cause a DivideByZeroException
        }
        catch (Exception ex) // Catch the error using the built-in Exception class
        {
            Console.WriteLine("An error occurred!");
            Console.WriteLine($"Error message: {ex.Message}");
        }
    }
}

output:
An error occurred!
Error message: Attempted to divide by zero.


// In simple words, the exception class is like an alarm
 system for your code. When something goes wrong, it raises an alarm (exception), and you can decide how to respond.

*/