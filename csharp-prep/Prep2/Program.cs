using System;

class Program
{
    static void Main(string[] args)
    {
        char letter;
        char sign;
        int gradePercentage;

        Console.Write("What is your grade percentage? ");
        gradePercentage = int.Parse(Console.ReadLine());

        if (gradePercentage >= 90)
        {
            letter = 'A';
        }
        else if (gradePercentage >= 80)
        {
            letter = 'B';
        }
        else if (gradePercentage >= 70)
        {
            letter = 'C';
        }
        else if (gradePercentage >= 60)
        {
            letter = 'D';
        }
        else
        {
            letter = 'F';
        }

        if (gradePercentage % 10 >= 7 && letter != 'A' || letter != 'F')
        {
            sign = '+';
        }

        else if (gradePercentage % 10 < 3 && letter != 'F')
        {
            sign = '-';
        }

        else
        {
            sign = ' ';
        }

        if (gradePercentage >= 70)
        {
            Console.WriteLine("You passed the course!");
        }
        else
        {
            Console.WriteLine("Try again!");
        }

        Console.WriteLine($"Your letter grade is {letter}{sign}.");
    }
}