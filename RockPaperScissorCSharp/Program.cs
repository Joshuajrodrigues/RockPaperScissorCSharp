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
            string[] choiseArr = { "Rock", "Paper", "Scissor" };
            Random rand = new Random();
            int index = rand.Next(choiseArr.Length);
            Console.WriteLine("Type 'r' for rock, 'p' for paper and 's' for scissor");
            string userInput = Console.ReadLine();

            Console.WriteLine("Your choice is " + userInput);
            Console.WriteLine("Computer choise is " + choiseArr[index]);

            Console.ReadLine();
        }
    }
}
