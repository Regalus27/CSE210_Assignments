using System.Dynamic;

class Reception : Event
{
    private string _email {get;}

    public Reception(string name, string description, string date, string time, Address address, string email): base(name, description, date, time, address)
    {
        _email = email;
    }

    public override string GetDetailedMessage()
    {
        string details = $"This is a Reception. Please RSVP at {_email}.";
        return base.GetStandardMessage() + $"\n{details}";
    }

    public override string GetShortMessage()
    {
        return $"Reception. {base._eventName}. {base._date}"; 
    }
}