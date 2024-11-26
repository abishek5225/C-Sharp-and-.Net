

/*

abstract class Shape
{
    // Abstract method (no implementation)
    public abstract double GetArea();
}

// Derived class
class Circle : Shape
{
    private double radius;

    // Constructor
    public Circle(double radius)
    {
        this.radius = radius;
    }

    // Implementing the abstract method
    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an object of Circle
        Shape circle = new Circle(5.0);

        // Call the GetArea method
        Console.WriteLine("Area of the circle: " + circle.GetArea()); // Output: Area of the circle: 78.5398
    }
}
*/