using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_scissors_paper
{
    class Program
    {
        static void Main(string[] args)
        {
            // Preparations 
            Random randomNumbers = new Random();

            double playerPoints = 0;
            double computerPoints = 0;

            int rock = 1, scissors = 2, paper = 3;

            // Inputs
            Console.Write("Enter your name: ");
            string playerName = Console.ReadLine();

            Console.Write("Enter number of game rounds: ");
            string input = Console.ReadLine();
            int totalRounds = Convert.ToInt32(input);

            Console.WriteLine();

            // Individual rounds
            for (int roundNumber = 0; roundNumber < totalRounds; roundNumber++)
            {
                // Computer chooses
                int computerChoice = randomNumbers.Next(1, 3 + 1);

                // Player chooses
                Console.Write("Enter R or S or P: ");
                string playerInput = Console.ReadLine();
                string playerInputUppercase = playerInput.ToUpper();
                int playerChoice = playerInputUppercase == "R" ?
                    rock : (playerInputUppercase == "S" ? scissors : paper);

                // Round evaluation
                string message = "";
                if (computerChoice == rock && playerChoice == scissors ||
                    computerChoice == scissors && playerChoice == paper ||
                    computerChoice == paper && playerChoice == rock)
                {
                    // Computer won
                    computerPoints += 1;
                    message = "I won";
                }
                else
                {
                    // Tie or player won
                    if (computerChoice == playerChoice)
                    {
                        // Tie
                        computerPoints += 0.5;
                        playerPoints += 0.5;
                        message = "Tie";
                    }
                    else
                    {
                        // Player won
                        playerPoints += 1;
                        message = "You won";
                    }
                }

                // Round output
                string playerChoiceInText = playerChoice == rock ?
                    "Rock" : (playerChoice == scissors ? "Scissors" : "Paper");
                string computerChoiceInText = computerChoice == rock ?
                    "Rock" : (computerChoice == scissors ? "Scissors" : "Paper");
                Console.WriteLine(playerName + ":Computer - " +
                    playerChoiceInText + ":" + computerChoiceInText);
                Console.WriteLine(message);
                Console.WriteLine();
            } // End of loop for game round

            // Game evaluation
            Console.WriteLine("GAME OVER - OVERALL RESULT");
            Console.WriteLine(playerName + ":Computer - " +
                playerPoints.ToString() + ":" + computerPoints.ToString());

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
