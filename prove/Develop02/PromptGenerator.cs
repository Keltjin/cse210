public class PromptGenerator 
{
    public List<string> prompt = new List<string>();
    public Random rand = new Random();

    public PromptGenerator()
    {
        prompt.Add("Who was the most interesting person I interacted with today?");
        prompt.Add("What was the best part of my day?");
        prompt.Add("How did I see the hand of the Lord in my life today?");
        prompt.Add("What was the strongest emotion I felt today?");
        prompt.Add("If I had one thing I could do over today, what would it be?");
        prompt.Add("How have I helped someone today?");
    }

    public string DisplayPrompt()
    {
        int randomIndex = rand.Next(0, prompt.Count);

        string randomElement = prompt[randomIndex];

        return randomElement;
    }
}