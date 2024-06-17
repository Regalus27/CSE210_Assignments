using System;

class Program
{
    static void Main(string[] args)
    {
        Job job = new()
        {
            _company = "Red Company",
            _title = "Demo",
            _startYear = 1990,
            _endYear = 1992
        };
        Job job1 = new()
        {
            _company = "Blue Company",
            _title = "Engineer",
            _startYear = 1983,
            _endYear = 1990
        };

        List<Job> jobs = [];
        jobs.Add(job);
        jobs.Add(job1);

        Resume resume = new()
        {
            _jobs = jobs,
            _name = "Bill Jones"
        };

        resume.DisplayResume();
    }
}