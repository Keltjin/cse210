using System;

class Program
{
    static void Main(string[] args)
    {
        char grade;
        string score;
        int userScore;

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

        if (userScore >= 70)
        {
            Console.WriteLine($"Congrats on passing you got {userScore}. Which is the letter {grade}");
        }

        else 
        {
            Console.WriteLine("You did not pass.");
        }
    }
}