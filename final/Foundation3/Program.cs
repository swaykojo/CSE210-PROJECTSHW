using System;

class Program
{
    static void Main(string[] args)
    {
        Lectures lectureEvent = new Lectures("Programming", "Programming with classes foundations", "April 1 2022", "8:30Am", "Accra Ghana No.57", "Awuah Godsway", 50);
        
        Outdoor outDoorEvent = new Outdoor("Family Unity", "Bulding Strong family unit in our country", "May 15 2022", "8:30Am", "Accra Ghana No.57", "Sunny");
        
        Receptions receptionsEvent = new Receptions("Birthday", "Birthday party for Obaayaa", "Sep 20 2022", "6:00Pm", "Accra Ghana NO.7", "awuahgodsway@yahoo.com");

        Console.WriteLine("Lecture Event Details");
        lectureEvent.DisplayStandardDetails();
        lectureEvent.DisplayFullDetails();
        lectureEvent.DisplayShortDescription();
        Console.WriteLine();
        

        Console.WriteLine("OutDoor Event Details");
        outDoorEvent.DisplayStandardDetails();
        outDoorEvent.DisplayFullDetails();
        outDoorEvent.DisplayShortDescription();
        Console.WriteLine();

        Console.WriteLine("Reception Event Details");
        receptionsEvent.DisplayStandardDetails();
        receptionsEvent.DisplayFullDetails();
        receptionsEvent.DisplayShortDescription();
    }
}