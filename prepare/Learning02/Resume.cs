public class Resume 
{
    public string name;
    public List<Job> jobs = new List<Job>();

    public Resume()
    {

    }

    public void DisplayJobs()
    {
        Console.WriteLine($"{name}:");
        Console.WriteLine("Jobs:");

        foreach(Job job in jobs)
        {
            job.DisplayJobDetails();
        }
    }
}