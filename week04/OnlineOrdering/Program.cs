using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("First Order");
        Order order1 = new Order(new Customer("Mark",new Address("15th Street","Houston","Texas","USA")));
        order1.AddProduct(new Product("Cheese", 194024123, 2.05, 4));
        order1.AddProduct(new Product("Pizza", 194024124, 4.00, 1));
        Console.WriteLine("Order 1");
        Console.WriteLine(order1.GetShippingLabel());
        order1.GetPackingLabel();
        order1.GetShippingCost();
        Console.WriteLine($"Total Cost: {order1.GetGrandTotal()}");
        Console.WriteLine("");

        Console.WriteLine("Second Order");
        Order order2 = new Order(new Customer("John", new Address("Chinatown","Gotham City","Illinois","USA")));
        order2.AddProduct(new Product("Cheerios", 12389012, 5.50, 4));
        order2.AddProduct(new Product("Apples", 819203821, 2.00, 10));
        Console.WriteLine(order2.GetShippingLabel());
        order2.GetPackingLabel();
        order2.GetShippingCost();
        Console.WriteLine($"Total Cost: {order2.GetGrandTotal()}");
        Console.WriteLine("");

        Console.WriteLine("Third Order");
        Order order3 = new Order(new Customer("Christian", new Address("Tatumbla","Tegucigalpa","Francisco Morazan","Honduras")));
        order3.AddProduct(new Product("Baleada", 623490823, 1, 12));
        order3.AddProduct(new Product("Candy", 890834129, 4.00, 2));
        Console.WriteLine(order3.GetShippingLabel());
        order3.GetPackingLabel();
        order3.GetShippingCost();
        Console.WriteLine($"Total Cost: {order3.GetGrandTotal()}");
        Console.WriteLine("");

        Console.WriteLine("Fourth Order");
        Order order4 = new Order(new Customer("Susan", new Address("Hogwarts School","London","England","UK")));
        order4.AddProduct(new Product("Root Beer", 12098490, 3.00, 3));
        order4.AddProduct(new Product("Mup", 12345616, 5.00, 5));
        Console.WriteLine(order4.GetShippingLabel());
        order4.GetPackingLabel();
        order4.GetShippingCost();
        Console.WriteLine($"Total Cost: {order4.GetGrandTotal()}");
        Console.WriteLine("");
    }
}