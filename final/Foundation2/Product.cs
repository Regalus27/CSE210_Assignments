class Product
{
    private string _id { get; }
    private string _name { get; }
    private double _price { get; }
    private int _quantity { get; }

    public Product(string id, string name, double price, int quantity)
    {
        _id = id;
        _name = name;
        if (price < 0)
        {
            price = 0; // Potential issue if discounts are applied via an item worth negative value?
        }
        _price = Math.Round(price, 2);
        if (quantity <= 0)
        {
            quantity = 1;
        }
        _quantity = quantity;
    }

    public double GetCost()
    {
        return Math.Round(_quantity * _price, 2);
    }

    public string GetFullProductSummary()
    {
        return $"ID {_id} | {GetSummaryName()} | {_quantity} @ ${Math.Round(_price, 2)}";
    }

    public string GetPackingProductSummary()
    {
        return $"ID {_id} | {GetSummaryName()} | Amount: {_quantity}";
    }

    private string GetSummaryName(int length = 15)
    {
        // Used to truncate or elongate product name for labelling
        int nameLength = _name.Length;
        string nameToReturn = _name;
        if (nameLength < length)
        {
            // If too short, add spaces
            nameToReturn += new string(' ', length - nameLength);
        }
        else if (nameLength > length)
        {
            // If too long, truncate
            nameToReturn = nameToReturn.Substring(0, length);
        }
        // No need for else, already correct length
        return nameToReturn;
    }
}