using System;

class Program
{
    static void Main(string[] args)
    {
       
       Console.Write("Breath in......");



       for(int i = 5; i > 0; i--) 
       {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
       }
    /*  
    List<string> animationDesign = new List<string>();
       animationDesign.Add("|");
       animationDesign.Add("/");
       animationDesign.Add("-");
       animationDesign.Add("\\");
       animationDesign.Add("|");
       animationDesign.Add("/");
       animationDesign.Add("-");
       animationDesign.Add("\\");

  //     foreach(string design in animationDesign)
   //    {
     //     Console.Write(design); 
       //   Thread.Sleep(1000);
     //     Console.Write("\b \b");

      // }
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(10); 

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
        } */
      

    }
}