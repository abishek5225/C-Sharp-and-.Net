/*

namespace Delegatesprogram{
    class Program {

        public delegate void Addnum(int a, int b);
        public delegate void Subnum(int a, int b);

        public void sum(int a, int b){
            int result = a+b;
            Console.WriteLine($"Sum: {result}");
        }

        public void subtract(int a, int b){
            int result =a - b;
            Console.WriteLine($"Difference: {result}");
        }

        public static void Main(){
            Program obj= new Program();

            Addnum delobj1=new Addnum(obj.sum);
            Subnum delobj2 = new Subnum(obj.subtract);

            delobj1(20,10);
            delobj2(20,10);
        }
    }
}
*/

/*
Explanation: In the above program, there are two delegates Addnum and Subnum. 
We are creating the object obj of the class Program because both the methods(addnum and subnum) 
are instance methods. So they need an object to call. 
If methods are static then there is no need to create the object of the class.
*/