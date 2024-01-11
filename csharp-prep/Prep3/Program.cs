using System;

class Program
{
    static void Main(string[] args)
    {
        string guessNumberString;
        string repeat;
        int magicNumber;
        int guessNumber;
        int counter;

        do
        {
            counter = 0;

            Random randomGenerator = new Random();
            magicNumber = randomGenerator.Next(1, 11);

            Console.Write("What is your guess? ");
            guessNumberString = Console.ReadLine();
            guessNumber = int.Parse(guessNumberString);

            while (guessNumber != magicNumber)
            {
                counter += 1;

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

            Console.WriteLine($"Congrats! You guess the right number! It took you {counter} times.");
            
            Console.Write("Would you like to play again? ");
            repeat = Console.ReadLine();

        } while (repeat != "no");
    }
}