using System;

class Program
{
    static void Main(string[] args)
    {
        Reference r = new Reference("Proverbs", "3", "5", "6");
        r.GetReference(); 

        string wordText = " Trust in the Lord with all thine heart; " +
         "and lean not unto thine own understanding " +
         ".In all thy ways acknowledge him,and he shall direct thy paths."; 
         
         Console.WriteLine($"{wordText}"); 
         Console.WriteLine();
         
         Console.WriteLine("Press enter to continue or type 'quit' to finish:");
         Console.ReadLine();

         string[] words = wordText.Split(" "); 

           Random random = new Random();
           int index = random.Next(words.Count());  

           string wordTextReplace = wordText.Replace(words[index], "_____").Replace(words[index], "_____");
           
           // This will clear the console
           Console.Clear();

           Console.WriteLine($"{wordTextReplace}");
             
 
} 
}