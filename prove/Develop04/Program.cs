using System;

class Program
{
    static void Main(string[] args)
    {
        int userInput = 0; 

        List<string> menu = new List<string> 
        {
            "Menu Options:", 
            "1. Start breathing activity",
            "2. Start reflecting activity",
            "3. Start listing activity",
            "4. Quit"
        }; 

        while (userInput != 4)
        {
            Console.Clear();
            foreach (string menuChoice in menu)
            {
               Console.WriteLine(menuChoice);
            } 
            Console.Write("Select a choice from the menu: ");
            userInput = int.Parse(Console.ReadLine());
            Console.Clear(); 

            if (userInput == 1) 
            {
              BreathingActivity breath = new BreathingActivity();
              breath.runBreathing();
            } 
            else if (userInput == 2 ) 
            {
              ReflectingActivity demo = new ReflectingActivity();
              demo.reflectingRun();
            } 
            else if (userInput == 3)
            {
              ListingActivity list = new ListingActivity();
              list.runListing();
            }
        }
    }
}