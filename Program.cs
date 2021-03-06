using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int secretNumber = random.Next(1, 101);

            Console.WriteLine("Can you guess the secret number?");
            Console.WriteLine("Before we start, tho, how much of a challenge do you like?");
            Console.WriteLine(@"
                - Easy - eight guesses (enter 1)
                - Medium - six guesses (enter 2)
                - Hard - four guesses (enter 3)
                - IWannaPlayTillIWin!!! - infinity guesses (enter 4)"
            );

            var input = Console.ReadLine();
            int userLevel = (int.Parse(input) - 1);
            int[] challengeLevels = { 8, 6, 4 };
            int guessesLeft = 0;

            Console.WriteLine("First guess? ");

            if (userLevel == 3)
            {
                guessesLeft = Int32.MaxValue;
            }
            else
            {
                guessesLeft = challengeLevels[userLevel];
            }

            while (guessesLeft > 0)
            {

                var guess = Console.ReadLine();
                int parsedGuess = int.Parse(guess);

                if (parsedGuess == secretNumber)
                {
                    Console.WriteLine($"Dingdingding! How'd you do that?! Homer Simpson says you won!! (_8(|) ");
                    break;
                }
                else if (parsedGuess < secretNumber)
                {
                    guessesLeft--;
                    Console.WriteLine($"Rrrrrnnt! Too low! Guesses left: {guessesLeft}.");
                }
                else if (parsedGuess > secretNumber)
                {
                    guessesLeft--;
                    Console.WriteLine($"Rrrrrnnt! Too high! Guesses left: {guessesLeft}.");

                }
            }

        }
    }

}




