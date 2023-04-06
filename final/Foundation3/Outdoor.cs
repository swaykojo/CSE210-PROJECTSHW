using System;

public class Outdoor : Event 
{
    private string _weather;

   

    public Outdoor(string title, string description, string date, string time, string address, string weather) : base(title, description, date, time, address)
    {
        _type = "Outdoor";
        _weather = weather;
       
    } 

    public void DisplayFullDetails()
    {
        
       Console.WriteLine("FULL DETAILS");
       Console.WriteLine($"Event Type:{_type}, Event title: {_title}, Description: {_description}, Date: {_date}, Forecast: {_weather}, Time: {_time}, Address: {_address}");
    }
}       