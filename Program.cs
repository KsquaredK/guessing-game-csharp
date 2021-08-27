// Write a console program in C# that invites the user to guess a number.

// The program should be written in increments. Each phase will add a little more complexity.

using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            // Phase 1

            //* 2.1. Create a variable to contain the secret number. This number should be hard-coded for now. 42 is a nice number.
            Random random = new Random();
            int secretNumber = random.Next(1, 101);
            // The program should...
            // 1.1 Display a message to the user asking them to guess the secret number.
            Console.WriteLine("Can you guess the secret number?");

            // 1.2 Display a prompt for the user's guess.
            Console.WriteLine("Your guess: ");
            // 3.1. Give the user four chances to guess the number.
            // 3.2. Continue to display the success or failure messages as in phase 2
            for (int i = 5; i > 0; i--)
            {
                // 1.3 Take the user's guess as input and save it as a variable.
                var guess = Console.ReadLine();
                // 4.1. Display the number of the user's current guess in the prompt. For example, if the user has already guessed one time, the prommpt should say something like Your guess (2)>.
                Console.WriteLine($"You guessed {guess}...");
                // 2.2 No longer display the user's guess. They know what they guessed, right?
                // 2.3 Compare the user's guess with the secret number. Display a success message if the guess is correct, otherwise display a failure message.
                int parsedGuess = int.Parse(guess);

                // 2. End the loop early if the user guesses the correct number.
                if (parsedGuess == secretNumber)
                {
                    Console.WriteLine($"How'd you do that?! You won!");
                    break;
                }
                else if (parsedGuess < secretNumber)
                {
                    Console.WriteLine("Too low! Try again - guesses left: {i}.");
                }
                else if (parsedGuess > secretNumber)
                {
                    Console.WriteLine("Too high! Try again.");

                }
            }
        }

    }

}

// Phase 5

// The program should be updated to...

// 1. Use a random number to set the secret number between 1 and 100 instead of a hard-coded number.
// 2. The prompt should display the number of guesses the user has left.

// Phase 6

// The program should be updated to...

// 1. Inform the user if their guess was too high or too low, when they guess incorrectly.

// Phase 7

// The program should be updated to...

// 1. Prompt the user for a difficulty level before they are prompted to guess the number.
// 2. The difficulty level should determine how many guesses the user gets. The difficulty levels should be:
// 	- Easy - this gives the user eight guesses.
// 	- Medium - this gives the user six guesses.
// 	- Hard - this gives the user four guesses.

// Phase 8

// The program should be updated to...

// 1. Add a difficulty level of "Cheater" which will cause the program to continue prompting the user until they get the answer correct.
//     }
// }




