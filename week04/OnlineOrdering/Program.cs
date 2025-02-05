using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("12th Street", "Chicago", "IL", "USA");
        Customer customer1 = new Customer("Mark", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Cheese", 194024123, 2.05, 4));
        order1.AddProduct(new Product("Pizza", 194024124, 4.00, 1));
        Console.WriteLine("---- Order 1 ----");
        Console.WriteLine(order1.GetShippingLabel());
        order1.GetPackingLabel();
        order1.GetShippingCost();
        Console.WriteLine($"Total Cost: {order1.GetGrandTotal()}");

        Address address2 = new Address("Main Road", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Alice", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Apples", 194024125, 1.50, 10));
        order2.AddProduct(new Product("Bananas", 194024126, 0.80, 8));
        Console.WriteLine("\n---- Order 2 ----");
        Console.WriteLine(order2.GetShippingLabel());
        order2.GetPackingLabel();
        order2.GetShippingCost();
        Console.WriteLine($"Total Cost: {order2.GetGrandTotal()}");
        
        Address address3 = new Address("Avenida Revolución", "Monterrey", "NL", "Mexico");
        Customer customer3 = new Customer("Carlos", address3);
        Order order3 = new Order(customer3);
        order3.AddProduct(new Product("Tacos", 194024127, 2.50, 5));
        order3.AddProduct(new Product("Soda", 194024128, 1.20, 3));
        Console.WriteLine("\n---- Order 3 ----");
        Console.WriteLine(order3.GetShippingLabel());
        order3.GetPackingLabel();
        order3.GetShippingCost();
        Console.WriteLine($"Total Cost: {order3.GetGrandTotal()}");

        Address address4 = new Address("Rue de Rivoli", "Paris", "Ile-de-France", "France");
        Customer customer4 = new Customer("Marie", address4);
        Order order4 = new Order(customer4);
        order4.AddProduct(new Product("Croissant", 194024129, 3.50, 6));
        order4.AddProduct(new Product("Coffee", 194024130, 2.80, 2));
        Console.WriteLine("\n---- Order 4 ----");
        Console.WriteLine(order4.GetShippingLabel());
        order4.GetPackingLabel();
        order4.GetShippingCost();
        Console.WriteLine($"Total Cost: {order4.GetGrandTotal()}$");
    }
}