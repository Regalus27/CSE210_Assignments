class WritingAssignment : Assignment
{
    private string _title;
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public new string GetSummary()
    {
        return $"{base.GetSummary()}\n{_title}";
    }
}