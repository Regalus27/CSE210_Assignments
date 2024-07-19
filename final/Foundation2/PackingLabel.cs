class PackingLabel : Label
{
    private List<Product> _products {get;}
    public PackingLabel(List<Product> products)
    {
        _products = products;
    }
    public override string GetLabelSummary()
    {
        string labelOutput = "Packing Label:";
        foreach (Product product in _products)
        {
            labelOutput += "\n" + product.GetPackingProductSummary();
        }
        return labelOutput;
    }
}