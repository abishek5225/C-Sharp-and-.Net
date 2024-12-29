using System;

class Program{
    static void Main(){
        int playerWins = 0;
        int ComputerWins = 0;
        int ties = 0;
        bool playAgain = true;

        Console.WriteLine("Welcome to ROCK | PAPER | SCISSORS");

        while(playAgain){
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Rock");
            Console.WriteLine("2. Paper");
            Console.WriteLine("3. Scissors");

            int playerChoice;

            while(!int.TryParse(Console.ReadLine(), out playerChoice) || playerChoice < 1 || playerChoice >3){
                Console.WriteLine("Invalid choice. Please choose a number between 1 and 3.");
            }

            string[] options = {"Rock", "Paper", "Scissors"};
            string playerMove = options[playerChoice -1];
            Random random = new Random();
            string computerMove = options[random.6Next(3)];

            Console.WriteLine($"\n You chose: {playerMove}");
            Console.WriteLine($"Computer chose: {computerMove}");

            if(playerMove == computerMove){
                Console.WriteLine("It's a tie!");
                ties++;
            }
            else if((playerMove == "Rock" && computerMove == "Scissors")||
            (playerMove == "Paper" && computerMove == "Rock") ||
            (playerMove == "Scissors" && computerMove == "Paper")){
                Console.WriteLine("You win!");
                playerWins++;
            }else{
                Console.WriteLine("Computer wins!");
                ComputerWins++;
            }
            Console.WriteLine("\n Scoreboard:");
            Console.WriteLine($"You: {playerWins} | Computer: {ComputerWins} | Ties: {ties}");

            Console.WriteLine("\n Do you want to play again? (y/n):");
            string response = Console.ReadLine().ToLower();
            playAgain = response == "y";
        }
        Console.WriteLine("\nThanks for playing.........");
    }
}