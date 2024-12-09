// Write a program which has class Book with data members book_name, ISBN, author &
// price and appropriate function members to read and display data members.

/*

class Book
{
    // Data members
    private string book_name;
    private string ISBN;
    private string author;
    private double price;

    // Method to read book details
    public void ReadBookDetails()
    {
        Console.Write("Enter Book Name: ");
        book_name = Console.ReadLine();

        Console.Write("Enter ISBN: ");
        ISBN = Console.ReadLine();

        Console.Write("Enter Author: ");
        author = Console.ReadLine();

        // Loop until a valid price is entered
        bool validInput = false;
        while (!validInput)
        {
            Console.Write("Enter Price: ");
            string priceInput = Console.ReadLine();

            // Try parsing the input to a double
            if (double.TryParse(priceInput, out price))
            {
                validInput = true; // Input is valid, exit the loop
            }
            else
            {
                Console.WriteLine("Invalid price. Please enter a numeric value.");
            }
        }
    }

    // Method to display book details
    public void DisplayBookDetails()
    {
        Console.WriteLine("\nBook Details:");
        Console.WriteLine("Book Name: " + book_name);
        Console.WriteLine("ISBN: " + ISBN);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: $" + price);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of Book
        Book myBook = new Book();

        // Reading book details
        myBook.ReadBookDetails();

        // Displaying book details
        myBook.DisplayBookDetails();
    }
}
*/