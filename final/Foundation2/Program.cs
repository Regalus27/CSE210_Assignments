using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        List<Order> orders = [];

        Address address1 = new("123 GitGud Ln", "Parryville", "Limgrave", "Lands Between", false);
        Customer customer1 = new("John", "Elden-Ring", address1);
        List<Product> products1 = [];
        products1.Add(new("23RE3", "One-Of-A-Kind Headphones", 2999.99, 1));
        products1.Add(new("5R2Y3", "Laptop", 549.99, 1));
        products1.Add(new("9E8T2", "XBox Controller", 8.99, 2));
        products1.Add(new("GYJS6", "Webcam", 49.99, 1));

        Address address2 = new("5435 Hylian Way", "Township", "Stateship", "Countrything", false);
        Customer customer2 = new("Jimmy", "John", address2);
        List<Product> products2 = [];
        products2.Add(new("23RE3", "Some stuff", 1999.99, 1));
        products2.Add(new("5R2Y3", "More stuff", 1549.99, 1));
        products2.Add(new("9E8T2", "Stuff with a long name hehehe", 28.99, 2));

        orders.Add(new(products1, customer1));
        orders.Add(new(products2, customer2));

        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetOrderSummary());
            Console.WriteLine();
        }
    }
}