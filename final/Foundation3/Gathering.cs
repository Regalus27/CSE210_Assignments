using System.Dynamic;

class Gathering : Event
{
    private string _weather {get;}

    public Gathering(string name, string description, string date, string time, Address address, string weather): base(name, description, date, time, address)
    {
        _weather = weather;
    }

    public override string GetDetailedMessage()
    {
        string details = $"This is an outdoor gathering. The weather will be {_weather}.";
        return base.GetStandardMessage() + $"\n{details}";
    }

    public override string GetShortMessage()
    {
        return $"Outdoor Gathering. {base._eventName}. {base._date}"; 
    }
}