using System;

class Program
{
    static void Main(string[] args)
    {
        // Declares the variables for the user names.
        string firstName;
        string lastName;

        // Asks the user for their first and last name.
        Console.Write("What is your first name? ");
        firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        lastName = Console.ReadLine();

        // Print out the user's first and last name.
        Console.WriteLine($"You name is {lastName}, {firstName}, {lastName}.");

    }
}