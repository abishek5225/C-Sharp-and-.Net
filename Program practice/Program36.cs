/*
Indexers
*/

class Names{
    private string[] names = new string[5];

    //indexer to get and set name
    public string this[int index]{
        get{ return names[index];}//get a name
        set{names[index] = value;}
    }
}
class Program36{
    static void Main(){
        Names obj = new Names();

        //using the indexer to set values
        obj[0] = "Abishek";
        obj[1]= "Sita";

        Console.WriteLine(obj[0]);
        Console.WriteLine(obj[1]);
    }
}