using System.IO;
public class Journal 
{
    public List<string> menu = new List<string>();
    public string entry;
    public List<string> entires = new List<string>();
    public List<string> dates = new List<string>();

    public Journal()
    {
        menu.Add("Welcome To My Public Journal.");
        menu.Add("Enter a number assocated with the command you would like to do.");
        menu.Add("1. Write");
        menu.Add("2. Display");
        menu.Add("3. Load");
        menu.Add("4. Save");
        menu.Add("5. Quit");
        menu.Add("Enter your choice here: ");
    }

    public void DisplayMenu()
    {
        string choice;

        do
        {
            foreach (string option in menu)
            {
                Console.WriteLine(option);
            }

            choice = Console.ReadLine();

            if(choice == "1")
            {
                DateTime theCurrentTime = DateTime.Now;
                PromptGenerator prompt = new PromptGenerator();

                string dateText = theCurrentTime.ToShortDateString();
                string randomPrompt = prompt.DisplayPrompt();
                Console.WriteLine(randomPrompt);

                entry = Console.ReadLine();
                entires.Add(entry);
                dates.Add(dateText);
            }

            else if (choice == "2")
            {
                for (int i = 0; i < entires.Count; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{dates[i]} - {entires[i]}");
                }
            }

            else if (choice == "3")
            {
                Console.Write("Enter the name of the file to load: ");
                string fileName = Console.ReadLine();

                if (File.Exists(fileName))
                {
                    using (StreamReader file = new StreamReader(fileName))
                    {
                        string line;
                        while ((line = file.ReadLine()) != null)
                        {
                            string[] parts = line.Split(" - ", 2); 
                            if (parts.Length == 2)
                            {
                                dates.Add(parts[0]);
                                entires.Add(parts[1]);
                            }
                        }
                    }
                    Console.WriteLine("File loaded succesfully.");

                    Console.WriteLine("\nLoaded Entries:");
                    for (int i = 0; i < entires.Count; i++)
                    {
                        Console.WriteLine($"{dates[i]} - {entires[i]}");
                    }
                }
                else
                {
                    Console.WriteLine("File does not exist.");
                }
            }
            

            else if (choice == "4")
            {
                Console.Write("What is name of the txt document you are saving it as? ");
                string fileName = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    for (int i = 0; i < entires.Count; i++)
                    {
                        outputFile.WriteLine($"{dates[i]} - {entires[i]}");
                    }
                }
            }

        } while (choice != "5");
       
    }
}