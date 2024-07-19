class ShippingLabel : Label
{
    Customer _customer {get;}

    public ShippingLabel(Customer customer)
    {
        _customer = customer;
    }

    public override string GetLabelSummary()
    {
        return $"Shipping Label:\n{_customer.GetCustomerSummary()}";
    }
}