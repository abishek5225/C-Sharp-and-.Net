/*
class Student{
    public string Name{get; set;}
    public int Score{get; set;}
}

class Program44{
    public delegate void Highscorehandler(string sname, int score);
    public static event Highscorehandler onHighScore;

    static void Main(){
        var students = new List<Student>{
            new Student {Name= "Abishek", Score=95},
            new Student {Name= "Jon" , Score= 85},
            new Student {Name= "Charlie", Score= 90},
            new Student {Name="Diana", Score= 88}
        };

        onHighScore += (name, score)=> Console.WriteLine($"{name}, {score}");

        var highscore = students.Where(s => s.Score >90);

        foreach(var container in highscore){
            onHighScore ?.Invoke(container.Name, container.Score);
        }
    }
}
*/