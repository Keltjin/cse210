using System;

class Program
{
    static void Main(string[] args)
    {
        // Declare the variables
        char grade;
        char sign;
        string score;
        int userScore;

        // Ask the user 
        Console.WriteLine("Welcome to the Grading Declcaration!");

        Console.Write("Plesae enter your score: ");
        score = Console.ReadLine();
        userScore = int.Parse(score);

        Console.WriteLine();
        
        if (userScore >= 90)
        {
            grade = 'A';
        }

        else if (userScore >= 80)
        {
            grade = 'B';
        }

        else if (userScore >= 70)
        {
            grade = 'C';
        }

        else if (userScore >= 60)
        {
            grade = 'D';
        }

        else
        {
            grade = 'F';
        }

        if (userScore % 10 >= 7 && (grade != 'A' || grade != 'F'))
        {
            sign = '+';
        }

        else if (userScore % 10 < 3 && grade != 'F')
        {
            sign = '-';
        }

        else
        {
            sign = ' ';
        }

        if (userScore >= 70)
        {
            Console.WriteLine($"Congrats on passing you got {userScore}. Which is the letter {grade}{sign}");
        }

        else 
        {
            Console.WriteLine("You did not pass.");
        }
    }
}