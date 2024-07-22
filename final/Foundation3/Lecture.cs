class Lecture : Event
{
    private string _speaker {get;}
    private int _capacity {get;}

    public Lecture(string name, string description, string date, string time, Address address, string speaker, int capacity) : base(name, description, date, time, address)
    {
        _speaker = speaker;
        if (capacity < 0)
        {
            capacity = 0;
        }
        _capacity = capacity;
    }

    public override string GetDetailedMessage()
    {
        string details = $"This is a Lecture, given by {_speaker} with a capacity of {_capacity} seats.";
        return base.GetStandardMessage() + $"\n{details}";
    }

    public override string GetShortMessage()
    {
        return $"Lecture. {base._eventName}. {base._date}"; 
    }
}