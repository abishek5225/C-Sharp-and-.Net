/*
Write a C# program to input two numbers. If both numbers are equal then throw your
own custom exception. Otherwise calculate sum of two numbers.
*/
/*
using System;


    // Custom exception class
    public class NumbersAreEqualException : Exception
    {
        public NumbersAreEqualException(string message) : base(message) { }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                // Input two numbers
                Console.Write("Enter the first number: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int num2 = int.Parse(Console.ReadLine());

                // Check if numbers are equal
                if (num1 == num2)
                {
                    throw new NumbersAreEqualException("The two numbers are equal. Custom exception thrown!");
                }

                // Calculate and display the sum
                int sum = num1 + num2;
                Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");
            }
            catch (NumbersAreEqualException ex)
            {
                // Handle custom exception
                Console.WriteLine($"Custom Exception: {ex.Message}");
            }
            catch (FormatException)
            {
                // Handle invalid input
                Console.WriteLine("Error: Please enter valid numbers.");
            }
            finally
            {
                // Always executed
                Console.WriteLine("Program execution completed.");
            }
        }
    }
*/