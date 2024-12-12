//Multicasting of a Delegate

class Program2
{
    public delegate void rectangle(double height, double width);

    public void area(double height, double width){
        double result = width * height;
        Console.WriteLine($"Area: {result}");
    }

    public void perimeter(double height, double width){
        double result = 2 * (height + width);;
        Console.WriteLine($"Perimeter: {result}");
    }

    public static void Main(){

        Program2 obj=new Program2();

        rectangle delrect=new rectangle(obj.area);

        delrect += obj.perimeter;

        delrect.Invoke(10,20);

    }
}