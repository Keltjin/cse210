using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        PromptGenerator prompt = new PromptGenerator();

        string test = prompt.DisplayPrompt();
        string test2 = prompt.DisplayPrompt();

        Console.WriteLine(test);
        Console.WriteLine(test2);
    }
}