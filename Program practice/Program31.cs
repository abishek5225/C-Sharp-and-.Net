/*
Write a C# program to handle index out of range exception.
*/
/*
class Program31{
    static void Main(){
        try{
            int[] numbers = {10,20,30,40,50};

            Console.WriteLine("Enter an index to access the array: ");
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine($"the value at index {index} is: {numbers[index]}");
        }
        catch(Exception ex){
            Console.WriteLine("Error: the index you entered is out of range.");
            Console.WriteLine($"Details: {ex.Message}");
        }
        finally{
            Console.WriteLine("Program ended");
        }
    }
}
*/