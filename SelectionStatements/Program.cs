using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Guess a number between 1 - 100");
            var r = new Random();

            var favNumber = r.Next(1, 100);

            

            var userInput = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Guess a number between 1 - 100");

            if (userInput == favNumber)
            {
                Console.WriteLine("Lucky Guess!");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too High");
            }
            else 
            {
                Console.WriteLine("Too Low!");
            }
        }
    }
}
