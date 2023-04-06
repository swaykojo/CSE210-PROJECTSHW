using System;

public class Customer 
{
   private string _customerName;

   private Address _address;

   public Customer(string customername, string street, string city, string state, string country)
   {
      _customerName = customername;
      _address = new Address(street, city, state, country);
   }


   public string GetCustomerName()
   {
     return _customerName;
   } 

   public void SetCustomerName(string customerName)
   {
     _customerName = customerName;
   }
   
   public bool IntheUSA()
   {
     return _address.IntheUSA();
   }

   public void DisplayAddress()
   {
     Console.WriteLine(_address.GetAddress());
   }

}