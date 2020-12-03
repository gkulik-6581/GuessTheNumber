using System;

namespace GuessTheNumber
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //TODO Check for correct input
            //TODO How to get next input
            //TODO Check for correct number
            //TODO Count user guesses

            Console.WriteLine("I am thinking of a whole number between 1 and 50. Enter your guess.");
            string userGuess;
            Random rnd = new Random();
            int compNum = rnd.Next(1, 50);
            int guessToInt;
            int numOfTries = 0;
            string cont;
            bool correct = false;

            //TODO Delete this line
            Console.WriteLine($"Answer " + compNum);

            //Trying to get new user input if guess is wrong
            while (correct == false)
            {
                //correct = false;
                numOfTries++;
                userGuess = Console.ReadLine();
                guessToInt = Int32.Parse(userGuess);

                if (guessToInt == compNum)
                {
                    numOfTries++;
                    correct = true;
                    Console.WriteLine($"Your guess is correct! The number was " + compNum + ". Congratulations. It only took you " + numOfTries + " guess(es).");
                }

                else if (guessToInt < 1 || guessToInt > 50)
                {
                    Console.WriteLine("Incorrect input. Enter a whole number between 1 and 50. Try again.");
                    //numOfTries++;
                    correct = false;
                    continue;
                }

                else if (guessToInt != compNum)
                {
                    //How do I get new user input?
                    Console.WriteLine("Your guess is incorrect. Would you like to try again? Y or N?");
                    //numOfTries++;
                    correct = false;
                    cont = Console.ReadLine();

                    if (cont == "Y")
                    {
                        continue;
                    }
                    else Console.WriteLine("Bye."); Environment.Exit(0);
                }
            }
        }
    }
}
