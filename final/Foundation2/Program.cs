using System;

class Program
{
    static void Main(string[] args)
    {

      List<Order> _orders  = new List<Order>();

        Customer c1 = new Customer("Jones", "newtown", "Timesquare", "NewYork", "USA");
        Customer c2 = new Customer("David", "north", "Accra", "Greater Accra", "GHANA");
        Customer c3 = new Customer("Lampard", "east-legon", "London", "London", "England");

        Order o1 = new Order(c1);
        
        Order o2 = new Order(c2);
       
        Order o3 = new Order(c3);
     

        _orders.Add(o1);
        _orders.Add(o1);
        _orders.Add(o1);

        Product p1 = new Product("Milk", 101, 1.5, 2);
        Product p2 = new Product("Bread", 102, 10, 25);
        Product p3 = new Product("Milo", 103, 15, 2);
        Product p4 = new Product("Phone", 214, 500, 1);
        Product p5 = new Product("laptop", 358, 1000, 1);
        Product p6 = new Product("T-Shirt", 15, 180, 3);
        Product p7 = new Product("Shoes", 784, 200, 2);
        Product p8 = new Product("Bags", 369, 20, 5);
        Product p9 = new Product("Television", 987, 2500, 1);
        Product p10 = new Product("Lightbuld", 101, 1.5, 2);

        o1.AddProduct(p1);
        o1.AddProduct(p2);
        o1.AddProduct(p3);

        o2.AddProduct(p4);
        o2.AddProduct(p5);
        o2.AddProduct(p6);

        o3.AddProduct(p7);
        o3.AddProduct(p8);
        o3.AddProduct(p9);
        o3.AddProduct(p10);

        
        o1.DisplayAll();
        o2.DisplayAll();
        o3.DisplayAll();



        
        

    }
}