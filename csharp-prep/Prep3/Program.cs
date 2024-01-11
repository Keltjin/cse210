using System;

class Program
{
    static void Main(string[] args)
    {
        // Declare all my variables
        string guessNumberString;
        string repeat;
        int magicNumber;
        int guessNumber;
        int counter;

        // Use a do-while loop to run the guessing game at least once.
        do
        {   
            // Creates a random number to guess between 1 and 10 and ask the user for the prompt.
            counter = 0;

            Random randomGenerator = new Random();
            magicNumber = randomGenerator.Next(1, 11);

            Console.Write("What is your guess? ");
            guessNumberString = Console.ReadLine();
            guessNumber = int.Parse(guessNumberString);

            // Checks to see if user guess the number or not.
            while (guessNumber != magicNumber)
            {
                // Keeps track of attempts to guess the number.
                counter += 1;

                // Lets the user know if they are higher or lower and prompts for a retry.
                if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");

                    Console.Write("Try again! ");
                    guessNumberString = Console.ReadLine();
                    guessNumber = int.Parse(guessNumberString);
                }

                else 
                {
                    Console.WriteLine("Higher");

                    Console.Write("Try again! ");
                    guessNumberString = Console.ReadLine();
                    guessNumber = int.Parse(guessNumberString);
                }
            }

            // Displays the result and asks the user if they want to play again.
            Console.WriteLine($"Congrats! You guess the right number! It took you {counter} times.");
            
            Console.Write("Would you like to play again? ");
            repeat = Console.ReadLine();

        } while (repeat != "no");
    }
}