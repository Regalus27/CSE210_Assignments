class Customer {
    private string _firstname { get; }
    private string _lastname { get; }
    private string _fullname
    {
        get => $"{_firstname} {_lastname}";
    }
    private Address _address { get; }

    public Customer(string firstname, string lastname, Address address)
    {
        _firstname = firstname;
        _lastname = lastname;
        _address = address;
    }

    public string GetCustomerSummary()
    {
        return $"{_fullname}\n{_address.GetAddress()}";
    }

    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }
}