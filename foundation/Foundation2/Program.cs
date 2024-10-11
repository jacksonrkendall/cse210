using System;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("459 S 5th W", "Rexburg", "Idaho", "USA");
        Address address2 = new Address("123 Canada St", "Mapletown", "Ontario", "Canada");
        
        Customer customer1 = new Customer("Jackson Kendall", address1);
        Customer customer2 = new Customer("Guy Canadian", address2);

        Product product1 = new Product("eggs", 001, 5, 1);
        Product product2 = new Product("milk", 002, 4, 2);
        Product product3 = new Product("potatoes", 003, 2, 3);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product1);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        List<Order> orders = new List<Order> { order1, order2 };

        foreach (var order in orders)
        {
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine($"Total Cost: {order.CalculateTotalCost():C}");
            Console.WriteLine();
        }
    }
}