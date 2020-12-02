using System;

namespace GuessTheNumber
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("I am thinking of a whole number between 1 and 50. Enter your guess.");
            string userGuess = Console.ReadLine();
            Random rnd = new Random();
            int compNum = rnd.Next(1, 50);
            int guessToInt = Int32.Parse(userGuess);
        }
    }
}
