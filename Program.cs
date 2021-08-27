﻿// Write a console program in C# that invites the user to guess a number.

// The program should be written in increments. Each phase will add a little more complexity.

using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            // Phase 1

            //* 2.1. Create a variable to contain the secret number. 
            // 5.1. Use a random number to set the secret number between 1 and 100 instead of a hard-coded number.
            Random random = new Random();
            int secretNumber = random.Next(1, 101);
            // The program should...
            // 1.1 Display a message to the user asking them to guess the secret number.
            Console.WriteLine("Can you guess the secret number?");

            // 1.2 Display a prompt for the user's guess.
            Console.WriteLine("Your guess: ");
            // 3.1. Give the user four chances to guess the number.
            // 3.2. Continue to display the success or failure messages as in phase 2
            int guessesLeft = 3;

            for (int i = 4; i > 0; i--)
            {
                // 1.3 Take the user's guess as input and save it as a variable.
                var guess = Console.ReadLine();
                // 4.1. Display the number of the user's current guess in the prompt. For example, if the user has already guessed one time, the prommpt should say something like Your guess (2)>.
                // 2. The prompt should display the number of guesses the user has left.
                Console.WriteLine($"You guessed {guess}...");
                // 2.2 No longer display the user's guess. They know what they guessed, right?
                // 2.3 Compare the user's guess with the secret number. Display a success message if the guess is correct, otherwise display a failure message.
                // 6.1. Inform the user if their guess was too high or too low, when they guess incorrectly.
                int parsedGuess = int.Parse(guess);
                guessesLeft = i - 1;

                // 2. End the loop early if the user guesses the correct number.
                if (parsedGuess == secretNumber)
                {
                    Console.WriteLine($"Dingdingding! How'd you do that?! Homer says you won!! (_8(|) ");
                    break;
                }
                else if (parsedGuess < secretNumber)
                {
                    Console.WriteLine($"Rrrrrnnt! Too low! Guesses left: {guessesLeft}.");
                }
                else if (parsedGuess > secretNumber)
                {
                    Console.WriteLine($"Rrrrrnnt! Too high! Guesses left: {guessesLeft}.");

                }
            }

        }
    }

}

// Phase 5

// The program should be updated to...


// Phase 6

// The program should be updated to...


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




