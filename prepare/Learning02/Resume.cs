public class Resume
{
    public string _name;
    public List<Job> _jobs;

    public void DisplayResume()
    {
        string resume_return = $"Name: {_name}";
        foreach (Job job in _jobs)
        {
            resume_return += $"\n{job.DisplayJob()}";
        }
        Console.WriteLine(resume_return);
    }
}