using System;

public class ListingActivity : Activity
{
    string activityName, activityDescription;
    int activityDurationInput; 

    List<string> prompt;

    public ListingActivity() : base()
    {
        activityName ="Listing Activity";

        activityDescription = ("This activity will help you reflect on the good things in " +
         "your life by having you list as many things as you can in a certain area."); 

         prompt = new List<string>
         {
            "----Who are people that you appreciate?----",
            "----What are personal strengths of yours?----",
            "----Who are people that you have helped this week?----",
            "----When have you felt the Holy Ghost this month?----",
            "----Who are some of your personal heroes?----"
         }; 

    } 

    public void runListing() 
         {
          Console.WriteLine($"Welcome to the {activityName}");
          Console.WriteLine();
          Console.WriteLine(activityDescription);
          Console.WriteLine();

          Console.Write("How long, in seconds, would you like for your session? ");
          activityDurationInput = int.Parse(Console.ReadLine());

          Console.WriteLine("Get ready.....");
          displaySpinner(5);
          Console.Clear();  
          
          Console.WriteLine("List as many responses you can to the following prompt:");
          int randomIndex = new Random().Next(0, prompt.Count());
          Console.WriteLine(prompt[randomIndex]);
          displayCountDown(5); 

           DateTime startTime = DateTime.Now;
           DateTime endTime = startTime.AddSeconds(activityDurationInput);
           while (DateTime.Now < endTime) 
           { 
            List<string> makeList = new List<string>();
             Console.WriteLine("You may begin in: ");
             string listInput = Console.ReadLine();
             makeList.Add(listInput);
             foreach(string user in makeList)
             {
               
             }
              Console.WriteLine($"You listed {makeList.Count} items!" );
           } 

            Console.WriteLine();
            Console.WriteLine("Well done!!!");
            displaySpinner(3);
            Console.WriteLine(); 

            Console.WriteLine($"You have completed another {activityDurationInput} seconds of the {activityName}");

           Console.WriteLine();
           displaySpinner(3);
         }
}