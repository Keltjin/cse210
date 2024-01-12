using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        // Declared all the variables
        int number;
        int max = 0;
        float sum = 0;
        float average;

        Console.WriteLine("Enter in a list of numbers. Type 0 when done.");
        
        // Does a do-while loop to allow numbers to be added to the list.
        do
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }

        } while (number != 0);

        // Goes through the list and find the max and sum of the numbers in the list.
        foreach (int num in numbers)
        {
            if (max < num)
            {
                max = num;
            }

            sum += num;
        }
        
        // Gets the average of the list and displays the sum, average, and max to the console.
        average = sum / numbers.Count;

        Console.WriteLine($"The sum is {sum}.");
        Console.WriteLine($"The average is {average}.");
        Console.WriteLine($"The largest number is {max}.");
    }
}