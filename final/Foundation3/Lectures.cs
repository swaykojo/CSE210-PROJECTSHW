using System;

public class Lectures : Event 
{
    private string _speaker;

    private int _capacityLimit;

    public Lectures(string title, string description, string date, string time, string address, string speaker, int capacityLimit) : base(title, description, date, time, address)
    {
        _type = "Lecture";
        _speaker = speaker;
        _capacityLimit = capacityLimit;
    } 

    public void DisplayFullDetails()
    {
        
       Console.WriteLine("FULL DETAILS");
       Console.WriteLine($"Event Type:{_type}, Speaker: {_speaker}, Event title: {_title}, Description: {_description}, Capacity Limit: {_capacityLimit}, Date: {_date}, Time: {_time}, Address: {_address}");
    }
        
    
}