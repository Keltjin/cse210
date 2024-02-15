using System.IO;
public class Journal 
{
    public List<string> menu = new List<string>();
    public string userResponse;
    // public List<string> entires = new List<string>();
    public List<string> dates = new List<string>();
    public Entry entry = new Entry();


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

            switch (choice)
            {
                case "1":
                    WriteEntry();
                    break;

                case "2":
                    DisplayEntries();
                    break;

                case "3":
                    LoadEntries();
                    break;

                case "4":
                    SaveEntries();
                    break;  
            }

        } while (choice != "5");
       
    }

    public void WriteEntry()
    {
        DateTime theCurrentTime = DateTime.Now;
        PromptGenerator prompt = new PromptGenerator();

        string dateText = theCurrentTime.ToShortDateString();
        string randomPrompt = prompt.DisplayPrompt();
        Console.WriteLine(randomPrompt);

        userResponse = Console.ReadLine();
        entry.entries.Add(userResponse);
        dates.Add(dateText);
    }

    public void DisplayEntries()
    {
        for (int i = 0; i < entry.entries.Count; i++)
        {
            Console.WriteLine();
            Console.WriteLine($"{dates[i]} - {entry.entries[i]}");
        }
    }

    public void LoadEntries()
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
                        entry.entries.Add(parts[1]);
                    }
                }
            }

            Console.WriteLine("File loaded succesfully.");

            Console.WriteLine("\nLoaded Entries:");
            for (int i = 0; i < entry.entries.Count; i++)
            {
                Console.WriteLine($"{dates[i]} - {entry.entries[i]}");
            }
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }

    public void SaveEntries()
    {
        Console.Write("What is name of the txt document you are saving it as? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            for (int i = 0; i < entry.entries.Count; i++)
            {
                outputFile.WriteLine($"{dates[i]} - {entry.entries[i]}");
            }
        }
    }
}