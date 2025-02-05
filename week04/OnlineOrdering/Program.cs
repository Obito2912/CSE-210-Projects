using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 South Kings Avenue", "Underwater", "Atlantis", "USA");
        Address address2 = new Address("987 West 253 Main Street", "Town", "Sidney", "AU");

        Customer customer1 = new Customer("\nFrancis", address1);
        Customer customer2 = new Customer("\nAlicia", address2);

        Product product1 = new Product("Shampoo", "SH123\n", 10.99m, 3);
        Product product2 = new Product("Tooth Paste", "TP456", 5.80m, 2);

        Product product3 = new Product("Washer", "WH123\n", 699.99m, 1);
        Product product4 = new Product("Dryer", "DR456", 799.99m, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"The total balance to pay is: ${order1.AddShippingCostToOrder()}");

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"The total balance to pay is: ${order2.AddShippingCostToOrder()}");

    }
}