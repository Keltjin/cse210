using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Establishes functions to be used.
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your Username: ");
            string userName = Console.ReadLine();

            return userName;
        }

        static int UserNumber()
        {
            Console.Write("Please enter Usernumber: ");
            int userNumber = int.Parse(Console.ReadLine());

            return userNumber;
        }

        static int SquareNumber(int squareNumber)
        {
            squareNumber *= squareNumber;
            
            return squareNumber;
        }

        static void DisplayResult(string userName, int squareNumber)
        {
            Console.WriteLine($"{userName}, the squared number you entered is {squareNumber}.");
        }

        // Declare the variables
        string userName;
        int userNumber;
        int squareNumber;

        // Calls a function to display a message to the user.
        DisplayWelcome();
        
        // Calls several function to get a userName, userNumber, and to square that userNumber.
        userName = PromptUserName();
        userNumber = UserNumber();
        squareNumber = SquareNumber(userNumber);
        
        // Prints out the result of the squared number and their userName.
        DisplayResult(userName, squareNumber);
    }
}