abstract class Event
{
    protected string _eventName {get;}
    protected string _description {get;}
    protected string _date {get;}
    protected string _time {get;}
    protected Address _address {get;}

    public Event(string name, string description, string date, string time, Address address)
    {
        _eventName = name;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public virtual string GetStandardMessage()
    {
        return $"{_eventName} on {_date} @ {_time}\n{_description}\n{_address.GetAddress()}";
    }

    public abstract string GetDetailedMessage();

    public abstract string GetShortMessage();
}