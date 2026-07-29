using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order(new Customer("Loik Dagnon", new Address("123 Avenue", "Ouidah", "CT", "BENIN")));
        Order order2 = new Order(new Customer("Jane Smith", new Address("456 Oak Ave", "Somewhere", "NY", "USA")));

        Product product1 = new Product("Widget", "W123", 10.99m, 2);
        Product product2 = new Product("Gadget", "G456", 5.49m, 3);
        Product product3 = new Product("Thingamajig", "T789", 15.99m, 1);
        Product product4 = new Product("Doodad", "D012", 7.99m, 4);
        Product product5 = new Product("Whatchamacallit", "W345", 12.49m, 2);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        order2.AddProduct(product4);
        order2.AddProduct(product5);
   
        string packingLabel1 = order1.GetPackingLabel();
        string shippingLabel1 = order1.GetShippingLabel();
        decimal total1 = order1.CalculateTotalCost();

        string packingLabel2 = order2.GetPackingLabel();
        string shippingLabel2 = order2.GetShippingLabel();
        decimal total2 = order2.CalculateTotalCost();     

        Console.WriteLine(packingLabel1);
        Console.WriteLine(shippingLabel1);
        Console.WriteLine($"Total Price: {total1}$");
        Console.WriteLine("----------------------------");

        Console.WriteLine(packingLabel2);
        Console.WriteLine(shippingLabel2);
        Console.WriteLine($"Total Price: {total2}$");
        Console.WriteLine("----------------------------");

    }
}