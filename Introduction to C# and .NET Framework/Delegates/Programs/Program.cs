namespace Delegatesprogram{
    class Program {

        public delegate void addnum(int a, int b);
        public delegate void subnum(int a, int b);

        public void sum(int a, int b){
            Console.WriteLine("Sum:"a+b);
        }

        public void subtract(int a, int b){
            Console.WriteLine("Difference: "a,b);
        }

        public static void Main(){
            Program obj= new Program();

            addnum delobj=new addnum()
        }
    }
}