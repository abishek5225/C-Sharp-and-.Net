/*
Create a class named 'Rectangle' with two data members 'length' and 'breadth' and two
methods to print the area and perimeter of the rectangle respectively. Its constructor
having parameters for length and breadth is used to initialize length and breadth of the
rectangle. Let class 'Square' inherit the 'Rectangle' class with its constructor having a
parameter for its side (suppose s) calling the constructor of its parent class as 'super(s,s)'.
Print the area and perimeter of a rectangle and a square.
*/

/*
using System;
class Rectangle{
    protected double length;
    protected double breadth;

    public Rectangle(double length, double breadth)
    {
        this.length = length;
        this.breadth = breadth;
    }

    public void PrintArea(){
        double area= length * breadth;
        Console.WriteLine("Area of Rectangle: " + area);
    }

    public void PrintPerimeter(){
        double perimeter= 2* (length * breadth);
        Console.WriteLine("Perimeter of Rectangle: " + perimeter);
    }
}

class Square:Rectangle{
    public Square(double side) : base(side, side){

    }
}

class Program23{
    static void Main(){
        Console.WriteLine("Rectangle:");
        Rectangle rectangle = new Rectangle(5, 10);
        rectangle.PrintArea();
        rectangle.PrintPerimeter();

        Console.WriteLine();


        Console.WriteLine("Square:");
        Square square = new Square(6);
        square.PrintArea();
        square.PrintPerimeter();
    }
}
 */