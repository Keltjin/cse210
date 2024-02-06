using System;

class Program
{
    static void Main(string[] args)
    {
        int gradePercentage;

        Console.Write("What is your grade percentage? ");
        gradePercentage = int.Parse(Console.ReadLine());

        if (gradePercentage >= 90)
        {
            Console.WriteLine("A");
        }
        else if (gradePercentage >= 80)
        {
            Console.WriteLine("B");
        }
        else if (gradePercentage >= 70)
        {
            Console.WriteLine("C");
        }
        else if (gradePercentage >= 60)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }
    }
}