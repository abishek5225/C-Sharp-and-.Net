/*
Create a class Polygon with data members to represent two dimensions and
parameterized constructor to initialize data members. Derive two classes Rectangle and
Triangle from Polygon class with appropriate member function to calculate area of each
rectangle and triangle.
*/
/*
using System.Drawing;

class Polygon{
    protected double dimension1;
    protected double dimension2;

    public Polygon(double d1, double d2){
        dimension1 = d1;
        dimension2 = d2;
    }
}

class Rectangle : Polygon{
    public Rectangle(double length, double width) : base (length, width){

    }

    public double CalculateArea(){
        return dimension1 * dimension2;
    }
}

class Triangle : Polygon{
    public Triangle(double baselength, double height) : base(baselength, height){

    }
    public double CalculateArea()
    {
        return 0.5 * dimension1 * dimension2;
    }
}

class Program{
    static void Main(){
        Console.WriteLine("Rectangle: ");
        Console.WriteLine("Enter lendth: ");
        double length = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter width: ");
        double width = Convert.ToDouble(Console.ReadLine());
        Rectangle rect = new Rectangle(length, width);
        Console.WriteLine("Area of Rectangle: " + rect.CalculateArea());


        Console.WriteLine();

        Console.WriteLine("Triangle: ");
        Console.WriteLine("Enter base length: ");
        double baseLength = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter height: ");
        double height = Convert.ToDouble(Console.ReadLine());
        Triangle tri = new Triangle(baseLength, height);
        Console.WriteLine("Area of Triangle: " + tri.CalculateArea());
    }
}
*/