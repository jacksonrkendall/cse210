using System;

class Program
{
    static void Main(string[] args)
    {
        // input for two jobs, utilizing classes in Job.cs
        Job job1 = new Job();
        job1._jobTitle = "Customer Service Rep";
        job1._company = "Melaleuca";
        job1._startYear = 2023;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._jobTitle = "Owner/Operator";
        job2._company = "Scan-A-Plan LLC";
        job2._startYear = 2023;
        job2._endYear = 2024;

        // input for the resume, using jobs
        Resume resume = new Resume();
        resume._name = "Jackson Kendall";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        // func to display the contents of the classes
        // job1.Display();
        // job2.Display();
        resume.Display();
            
    }
}