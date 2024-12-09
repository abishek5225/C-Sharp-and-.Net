//3. Write a C# program to illustrate call by value and call by reference.

/*
class Program3
{
    // Call by Value method
    static void IncrementByValue(int number)
    {
        number += 5; // This will not affect value1 in Main
    }

    // Call by Reference method
    static void IncrementByReference(ref int number)
    {
        number += 5; 
    }
    static void Main()
    {
        int value1 = 5;
        int value2 = 10;

        Console.WriteLine($"Before method calls: value1 = {value1}, value2 = {value2}");

        // Call by Value
        IncrementByValue(value1);
        Console.WriteLine($"After Call by Value: value1 = {value1}");

        // Call by Reference
        IncrementByReference(ref value2);
        Console.WriteLine($"After Call by Reference: value2 = {value2}");
    }


}
*/