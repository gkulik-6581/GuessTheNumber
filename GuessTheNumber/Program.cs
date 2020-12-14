using System;

namespace GuessTheNumber
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("I am thinking of a whole number between 1 and 50. Enter your guess.");
            string userGuess;
            Random rnd = new Random();
            int compNum = rnd.Next(1, 50);
            int guessToInt;
            int numOfTries = 0;
            string cont;
            bool correct = false;

            //TODO possibly add hints for higher or lower?

            //This line is for testing
            //Console.WriteLine($"Answer is " + compNum);

            while (correct == false)
            {
                numOfTries++;
                userGuess = Console.ReadLine();
                guessToInt = Int32.Parse(userGuess);

                if (guessToInt == compNum)
                {
                    correct = true;
                    Console.WriteLine($"Your guess is correct! The number was " + compNum + ". Congratulations. It only took you " + numOfTries + " guess(es).");
                }

                else if (guessToInt < 1 || guessToInt > 50)
                {
                    Console.WriteLine("Incorrect input. Enter a whole number between 1 and 50. Try again.");
                    continue;
                }

                else if (guessToInt != compNum)
                {
                    Console.WriteLine("Your guess is incorrect. Would you like to try again? Y or N?");
                    cont = Console.ReadLine();
                    cont = cont.ToUpper();

                    if (cont != "Y")
                    {
                        Console.WriteLine("Bye.");
                        break;
                    }
                    Console.WriteLine("Enter your next guess.");
                }
            }
        }
    }
}
