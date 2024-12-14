class Program3{
    public static void Main(){
        List<int> numbers = new List<int> {1,2,3,4,5,6,7,8,9,10};
        var evennum = numbers.Where(x=> x%2 == 0);

        foreach(var result in evennum){
            Console.WriteLine(result);
        }
    }
}