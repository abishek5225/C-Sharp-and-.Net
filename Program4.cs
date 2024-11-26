//4.Write a C# program to illustrate different parameters like ref, out, params, optional, etc.

/*

class Program
{
    // Method using 'ref' parameter
    static void AddTen(ref int number)
    {
        number += 10;
    }

    // Method using 'out' parameter
    static void GetDetails(out string name, out int age)
    {
        name = "John Doe";
        age = 30;
    }

    // Method using 'params' parameter
    static int Sum(params int[] numbers)
    {
        int total = 0;
        foreach (int num in numbers)
        {
            total += num;
        }
        return total;
    }

    // Method using optional parameters
    static void PrintMessage(string message = "Hello, World!", int repeatCount = 1)
    {
        for (int i = 0; i < repeatCount; i++)
        {
            Console.WriteLine(message);
        }
    }

    static void Main(string[] args)
    {
        // Demonstrating 'ref' parameter
        int number = 5;
        Console.WriteLine("Before AddTen: " + number);  // Output: 5
        AddTen(ref number);
        Console.WriteLine("After AddTen: " + number);   // Output: 15

        // Demonstrating 'out' parameter
        GetDetails(out string name, out int age);
        Console.WriteLine($"Name: {name}, Age: {age}"); // Output: Name: John Doe, Age: 30

        // Demonstrating 'params' parameter
        int total = Sum(1, 2, 3, 4, 5);
        Console.WriteLine("Sum: " + total);             // Output: Sum: 15

        // Demonstrating optional parameters
        PrintMessage();                                 // Output: Hello, World!
        PrintMessage("Goodbye!", 3);                    // Output: Goodbye! (repeated 3 times)
    }
}
*/