using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1.company = "Microsoft";
        job1.jobTitle = "Software Engineer";
        job1.startYear = int.Parse("2019");
        job1.endYear = int.Parse("2022");

        Job job2 = new Job();
        job2.company = "Apple";
        job2.jobTitle = "Manager";
        job2.startYear = int.Parse("2022");
        job2.endYear = int.Parse("2023");

        Resume myResume = new Resume();
        myResume.name = "David Gjennestad";
        
        myResume.jobs.Add(job1);
        myResume.jobs.Add(job2);

        myResume.DisplayJobs();
    }   
}