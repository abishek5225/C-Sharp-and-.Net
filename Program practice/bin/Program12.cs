//

    // Define the Rectangle class
    class Rectangle
    {
        // Data members
        private int length;
        private int breadth;

        // Constructor to initialize length and breadth
        public Rectangle()
        {
            length = 100;
            breadth = 200;
        }

        // Method to calculate the area of the rectangle
        public void CalculateArea()
        {
            return length * breadth;
        }
    }

    // Main program class
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of the Rectangle class
            Rectangle rectangle = new Rectangle();

            // Calculate and print the area
            int area = rectangle.CalculateArea();
            Console.WriteLine("The area of the rectangle is: " + area);
        }
    }