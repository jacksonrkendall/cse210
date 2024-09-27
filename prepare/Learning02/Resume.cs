// creating a classs for a resume, using job classes
public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

        // function to display the contents of the class, using loop to iterate
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }

}
