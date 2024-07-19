class Address
{
    private string _city { get; }
    private string _country { get; }
    private string _state { get; }
    private string _street { get; }
    private bool _isInUSA { get; }

    public Address(string street, string city, string state, string country, bool inUSA)
    {
        _city = city;
        _country = country;
        _state = state;
        _street = street;
        _isInUSA = inUSA;
    }

    public string GetAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }

    public bool IsInUSA()
    {
        return _isInUSA;
    }
}