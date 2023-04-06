using System;

public class Product
{
   private string _productName;

   private int _productId;

   private double _productPrice;

   private int _productQuantity;

 

    public Product(string productName, int productId, double productPrice, int productQuantity)
    {
        _productName = productName;
        _productId = productId;
        _productPrice = productPrice;
        _productQuantity = productQuantity;
    }


   public  double GetTotalPrice()
   {
     double result = _productPrice * _productQuantity;
     return result;
   }
    
    public void DisplayProduct()
    {
        for (int i = 0; i < _productQuantity; i++)
        {
            Console.WriteLine($"Name: {_productName}, ID{_productId}");
        }
    }
}