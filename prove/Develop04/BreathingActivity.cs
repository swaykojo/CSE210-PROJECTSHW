using System; 

public class BreathingActivity : Activity
{   
    string activityName, activityDescription;
    int activityDurationInput;
        public BreathingActivity() : base()
    {  

        activityName = "Breathing Activity";
        activityDescription = ("This activity will help you relax by walking your through breathing in and out slowly."  + 
            " Clear your mind and focus on your breathing.");
       
    } 
     
    public void runBreathing()
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
           DateTime startTime = DateTime.Now;
           DateTime endTime = startTime.AddSeconds(activityDurationInput);
           while (DateTime.Now < endTime) 
           {
             breathIn();
             breathOut();
             Console.WriteLine();
           } 

          Console.WriteLine();
          Console.WriteLine("Well done!!!");
          displaySpinner(3);
          Console.WriteLine(); 

          Console.WriteLine($"You have completed another {activityDurationInput} seconds of the {activityName}");

          Console.WriteLine();
          displaySpinner(3);
    }
    public void breathIn()
    {
       Console.Write("Breathe in...");
       for(int i = 5; i > 0; i--) 
       {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
       }
    } 
     public void breathOut() 
     {
      Console.Write("Now breathe out...");
       for(int i = 5; i > 0; i--) 
       {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
       }
     }
}
