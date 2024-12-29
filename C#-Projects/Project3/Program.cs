
class Program{
    public delegate void TaskEventHandler(string taskName);
    
    public static event TaskEventHandler ? OnTaskCompleted;

    static void Main(){
        int delaySeconds;
        Console.WriteLine("Welcome to the Task Reminder App..");
        Console.WriteLine("Enter your task: ");
        string taskName = Console.ReadLine();

        Console.WriteLine("Enter time in seconds: ");

        if(!int.TryParse(Console.ReadLine(), out delaySeconds) || delaySeconds <= 0){
            Console.WriteLine("Invalid time input. Please restart and enter a positive number.");
            return;
        }

        OnTaskCompleted += NotifyTask;

        Console.WriteLine($"Task \"{taskName}\" will remind you in {delaySeconds} seconds.");

        Thread.Sleep(delaySeconds * 1000);

        OnTaskCompleted?.Invoke(taskName);

        OnTaskCompleted -= NotifyTask;

        static void NotifyTask(string taskName){
            Console.WriteLine($"Reminder: It's time to work on your task, \"{taskName}\" ");
        }
    }
}