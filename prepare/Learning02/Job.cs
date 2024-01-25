public class Job 
{
    public string company;
    public string jobTitle;
    public int startYear;
    public int endYear;

    public Job()
    {

    }

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{jobTitle} ({company}) {startYear}-{endYear}");
    }
}