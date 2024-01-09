using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their first and last name and sotes them into variables.
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine();

        // Displays the variables to the console.
        Console.Write($"My name is {lastName}, {firstName} {lastName}.");
    }
}