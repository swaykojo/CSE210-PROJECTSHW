using System;

public class Address
{
    private string _streetAddress;

    private string _city;
    private string _state;
    private string _country;



    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetAddress()
    {
            return $"Street Address: {_streetAddress}, City: {_city}, State: {_state}, Country: {_country}";
    } 
     public bool IntheUSA()
     {
        return _country == "USA";
     }
}
  