public class Resume
{
    public string _name;
    public List<Job> _resume = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Notice the use of the custom data type "Job" in this loop
        foreach (Job resume in _resume)
        {
            // This calls the Display method on each job
            resume.DisplayJobDetails();
        }
    }

}