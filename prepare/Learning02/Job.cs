public class Job
{
    public string _title;
    public string _company;
    public int _startYear;
    public int _endYear;

    public string DisplayJob()
    {
        return $"{_title} ({_company}) {_startYear}-{_endYear}";
    }
}