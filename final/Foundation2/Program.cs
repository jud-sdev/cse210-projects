using System;

class Program {
    static void Main(string[] args) {
        Address address1 = new Address("37 Baba-Adisa St", "Ibeju-Lekki", "Lagos", "Nigeria");
        Address address2 = new Address("123 Main St", "Idaho", "Salt Lake", "USA");

        Customer customer1 = new Customer("Ebigide Jude", address1);
        Customer customer2 = new Customer("Eric Carter", address2);

        Product product1 = new Product("Phone", 14356, 50, 1);
        Product product2 = new Product("Television", 90232, 70.5, 2);
        Product product3 = new Product("Refrigerator", 34562, 30, 3);

        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GeneratePackingLabel());
        Console.WriteLine(order1.GenerateShippingLabel());
        Console.WriteLine($"Total cost: ${order1.CalculateTotalCost()}");

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine(order2.GeneratePackingLabel());
        Console.WriteLine(order2.GenerateShippingLabel());
        Console.WriteLine($"Total cost: ${order2.CalculateTotalCost()}");
    }
}