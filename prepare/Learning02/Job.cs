// creating a classs for a job history
public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

// function to display the contents of the class
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

}

