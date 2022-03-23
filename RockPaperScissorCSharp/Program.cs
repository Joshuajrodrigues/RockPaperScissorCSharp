using System;

namespace RockPaperScissorCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************");
            Console.WriteLine("****Rock Paper Scissors*****");
            Console.WriteLine("******************");
            int playerScore = 0;
            int computerScore = 0;
            string isPlay = "y";
            do
            {

            Console.WriteLine("Type 'r' for rock, 'p' for paper and 's' for scissor. Q to exit");
            string userInput = Console.ReadLine();
            
            string[] choiseArr = { "Rock", "Paper", "Scissor" };
            Random rand = new Random();
            int index = rand.Next(choiseArr.Length);
            string computerChoise = choiseArr[index];


            switch (userInput)
            {
                case "s":
                    Console.WriteLine("Your choice is Scissor ");
                    Console.WriteLine("Computer choise is " + computerChoise);
                    break;
                case "p":
                    Console.WriteLine("Your choice is Paper ");
                    Console.WriteLine("Computer choise is " + computerChoise);
                    break;
                case "r":
                    Console.WriteLine("Your choice is Rock ");
                    Console.WriteLine("Computer choise is " + computerChoise);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

            if(userInput == computerChoise.ToLower().Substring(0, 1))
            {
                Console.WriteLine("Its a tie.");
            }
            else if((userInput == "r" && computerChoise == "Paper") || (userInput == "p" && computerChoise == "Scissor") || (userInput == "s" && computerChoise == "Rock"))
            {
                Console.WriteLine("Computer wins!");
                    computerScore++;
            }
            else if(( computerChoise == "Rock" && userInput == "p") || (computerChoise == "Paper" && userInput  == "s") || (computerChoise == "Scissor" && userInput  == "r"))
            {
                Console.WriteLine("User wins!");
                    playerScore++;
            }
            else
            {
                Console.WriteLine("Please enter correct key.");
            }
                Console.WriteLine("******SCORE*********");
                Console.WriteLine("**USER: "+playerScore+"\n**COMPUTER: "+computerScore);
                Console.WriteLine("Play Again ? q for quit. Random any key to play again.");
                isPlay= Console.ReadLine();
                Console.Clear();
            } while (isPlay != "q");
        }
    }
}
