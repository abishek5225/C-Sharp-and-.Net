
/*

class Program{
    static void Main(){
        Func<int, int, int> add = (a,b) => a+b;

        Console.WriteLine(add(10,20));
    }
}
*/

/*
what is Func?
Func is a predefined generic delegate in C# that represents a 
method which takes input parameters and returns a value.

You can think of it as a shortcut to avoid defining custom delegates manually.

How Func Works in This Case?
int Add(int a, int b)
{
    return a + b;
}
Instead of writing this long form:
Func<int, int, int> add = (a, b) => a + b;

*/