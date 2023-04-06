using System;

public class Order
{
    private List<Product> _products = new List<Product>();


    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }


    public double GetOrderTotal()
    {
        double orderCost = 0;
        _products.ForEach(product => orderCost += product.GetTotalPrice());
        return Math.Round(orderCost + (_customer.IntheUSA() ? 5 : 35), 2);
    } 

    public void AddProduct(Product product)
    {
        _products.Add(product);
    } 

    public void DisplayPackingLabel()
    {
        _products.ForEach(product => product.DisplayProduct());
    } 

    public void DisplayShippingLabel()
    {
        Console.WriteLine(_customer.GetCustomerName());
        _customer.DisplayAddress();
    } 

    public void DisplayAll()
    {
        DisplayPackingLabel();
        DisplayShippingLabel();
        Console.WriteLine($"Cost: ${GetOrderTotal()}\n");
    }


}