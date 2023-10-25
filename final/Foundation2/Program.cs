using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create some products
        Product product1 = new Product("Product 1", "P001", 10.99, 2);
        Product product2 = new Product("Product 2", "P002", 15.99, 1);
        Product product3 = new Product("Product 3", "P003", 5.99, 3);

        // Create customer addresses
        Address usaAddress = new Address("123 Main St", "New York", "NY", "USA");
        Address nonUsaAddress = new Address("456 Elm St", "Toronto", "ON", "Canada");

        // Create customers
        Customer usaCustomer = new Customer("John Doe", usaAddress);
        Customer nonUsaCustomer = new Customer("Jane Smith", nonUsaAddress);

        // Create orders
        Order order1 = new Order(usaCustomer);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(nonUsaCustomer);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display packing labels, shipping labels, and total prices
        Console.WriteLine("Order 1 Packing Label:\n" + order1.GetPackingLabel());
        Console.WriteLine("Order 1 Shipping Label:\n" + order1.GetShippingLabel());
        Console.WriteLine("Order 1 Total Price: $" + order1.CalculateTotalPrice());

        Console.WriteLine("\nOrder 2 Packing Label:\n" + order2.GetPackingLabel());
        Console.WriteLine("Order 2 Shipping Label:\n" + order2.GetShippingLabel());
        Console.WriteLine("Order 2 Total Price: $" + order2.CalculateTotalPrice());
    }
}