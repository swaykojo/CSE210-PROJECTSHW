using System;

public class Activity {
    private string _activityName;
    private string _activityDescription;

    private string _activityDuration;

    

     public Activity() 
     {
       
     } 

     public string GetActivityName() 
     {
        return _activityName;
     } 

     public void SetActivityName(string activityName) 
     { 
        _activityName = activityName;

     } 

     public string GetActivityDescription() 
     {
        return _activityDescription;
     } 

     public void SetActivityDescription(string activityDescription) 
     {
        _activityDescription = activityDescription;
     } 
    
    public string GetActivityDuration()
    {
        return _activityDuration;
    } 
    public void SetActivityDuration(string activityDuration) 
    {
        _activityDuration = activityDuration;
    }
    public string GetWelcomeMessage()
    {
        return $"Welcome to the {_activityName}";
    } 

    public string GetDescriptionMessage() 
    {
        return $"{_activityDescription}";
    } 

    public string GetDurationMessage() 
    {
        return $"{_activityDuration}";
    }

    public void displaySpinner(int numSecondsToRun)
    {
        List<string> animationDesign = new List<string>();
       animationDesign.Add("|");
       animationDesign.Add("/");
       animationDesign.Add("-");
       animationDesign.Add("\\");
       animationDesign.Add("|");
       animationDesign.Add("/");
       animationDesign.Add("-");
       animationDesign.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(numSecondsToRun); 

        int i = 0;

        while (DateTime.Now < endTime)
        {
           string design = animationDesign[i];
            Console.Write(design); 
            Thread.Sleep(1000);
            Console.Write("\b \b");   

            i++;

            if (i >= animationDesign.Count)   
            {
                i = 0;
            }     
        }
 
        Console.Write(" ");
    } 
 
    public void displayCountDown(int numSecondsToRun)
    {
        for (int i = numSecondsToRun; i >= 1; i--)
        {            
            Console.Write(string.Format("You may begin in: {0}", i));
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000);
        }
    }
} 
