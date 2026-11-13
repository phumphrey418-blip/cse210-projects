using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1: Customer living in the USA
        Address address1 = new Address("123 Maple Street", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Wireless Mouse", "WM-101", 25.50m, 2));
        order1.AddProduct(new Product("Mechanical Keyboard", "KB-202", 75.00m, 1));

        // Order 2: Customer living outside the USA
        Address address2 = new Address("456 Queen Street West", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Bob Smith", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("USB-C Hub", "UC-303", 30.00m, 2));
        order2.AddProduct(new Product("Monitor Stand", "MS-404", 45.00m, 1));
        order2.AddProduct(new Product("HDMI Cable", "HD-505", 12.99m, 3));

        // Display results for Order 1
        Console.WriteLine("============================");
        Console.WriteLine("          ORDER 1           ");
        Console.WriteLine("============================");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("\n" + order1.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order1.CalculateTotalCost():F2}\n");

        // Display results for Order 2
        Console.WriteLine("============================");
        Console.WriteLine("          ORDER 2           ");
        Console.WriteLine("============================");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("\n" + order2.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order2.CalculateTotalCost():F2}\n");
    }
}


