class Order
{
    List<Product> _products {get;}
    List<Label> _labels {get;}
    Customer _customer {get;}

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
        _labels = [];
        PackingLabel packingLabel = new(_products);
        ShippingLabel shippingLabel = new(_customer);
        _labels.Add(packingLabel);
        _labels.Add(shippingLabel);
    }

    private double CalculateShipping()
    {
        if (_customer.IsInUSA())
        {
            return 5.0;
        }
        else
        {
            return 35.0;
        }
    }

    private double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.GetCost();
        }
        totalCost += CalculateShipping();
        return Math.Round(totalCost, 2);
    }

    public string GetOrderSummary()
    {
        string summary = $"Order Summary:\nTotal Cost: ${CalculateTotalCost()}\nShipping: ${CalculateShipping()}";
        foreach (Product product in _products)
        {
            summary += "\n" + product.GetFullProductSummary();
        }
        foreach (Label label in _labels)
        {
            summary += "\n" + label.GetLabelSummary();
        }
        return summary;
    }
}