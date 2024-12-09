/*
Create a class Polygon with data members: dimension1 and dimension2 and a member
function: ReadDimension () to read data members. Derive two classes Rectangle and
Triangle from Polygon class with appropriate member function to calculate area of each
rectangle and triangle .
*/

/*
class Polygon{

    public double dimention1;
    public double dimention2;

    public void ReadDimension(){
        Console.WriteLine("Enter the first dimention: ");
        dimention1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second dimention: ");
        dimention2 = Convert.ToDouble(Console.ReadLine());
    }
}
class Rectangle : Polygon{
    public double CalculateArea(){
        return dimention1 * dimention2;
    }
}

class Triangle : Polygon{
    public double CalculateArea(){
        return 0.5 * dimention1 * dimention2;
    }
}

class Program20{
    static void Main(){
        //for rectangle
        Rectangle rect = new Rectangle();
        Console.WriteLine("Rectangle: ");
        rect.ReadDimension();
        Console.WriteLine("Area of Rectangle: "+rect.CalculateArea());

        Console.WriteLine();

        //for triangle
        Triangle tri = new Triangle();
        Console.WriteLine("Triangle: ");
        tri.ReadDimension();
        Console.WriteLine("Area of Triangle: "+tri.CalculateArea());

    }
}
*/