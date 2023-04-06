using System;

public class Event 
{
   protected string _type, _title, _description, _date, _time, _address;

    public Event(string title, string description, string date, string time, string address)
    { 
        
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    } 

    public void DisplayStandardDetails()
    { 
        Console.WriteLine("STANDARD DETAILS:");
        Console.WriteLine($"Event title: {_title}, Description: {_description}, Date: {_date}, Time: {_time}, Address: {_address},");
    } 

    public void DisplayShortDescription()
    {
        Console.WriteLine("SHORT DESCRIPTIONS:");
        Console.WriteLine($"Type: {_type}, Event: {_title}, Date: {_date}");
        
    }
  
    }
    