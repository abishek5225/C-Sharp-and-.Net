/*
Write a C# program to check whether a number is prime or composite using action
delegate.
*/

/*
class Program26
{
    static void Main()
    {
        Action<int> CheckPrimeorComposite = (num) =>
        {
            if (num < 1)
            {
                Console.WriteLine(num + " is neither prime nor composite");
                return;
            }
            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine(num + " is a prime number");
            }
            else
            {
                Console.WriteLine(num + " is a composite number");
            }
        };
        Console.WriteLine("Enter a number to check: ");
        int number = int.Parse(Console.ReadLine());
        CheckPrimeorComposite(number);
    }
}
*/