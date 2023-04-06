using System;

public class Receptions : Event 
{
    private string _rsvpEmail;

   

    public Receptions(string title, string description, string date, string time, string address, string rsvpEmail) : base(title, description, date, time, address)
    {
        _type = "Reception";
        _rsvpEmail = rsvpEmail;
       
    } 

    public void DisplayFullDetails()
    { 
       Console.WriteLine("FULL DETAILS");
       Console.WriteLine($"Event Type:{_type}, Event title: {_title}. Description: {_description}, RSVP At:{_rsvpEmail}, Date: {_date},  Time: {_time}, Address: {_address}");
    }
}       