using System;

 class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Prep3 World!");  
          
          //Start by asking the user for the magic number. (In future steps, we will change this to have the computer generate a random number, but to get started, we'll just let the user decide what it is.)
         
           // At this point, you won't have any loops.""" 
           Random randomGenerator = new Random();
           int magicNumber = randomGenerator.Next(1, 100);
            
          // Initializing the number of guesses 
          int countGuesses = 0;

           Console.WriteLine($"What is the magic number? {magicNumber}");
            //  Ask the user for a guess. 
            
            string response = "yes";

            int guessNumber = -1; 

            bool play = true;
            while (play) {
                
                while (guessNumber != magicNumber) {
            
            countGuesses +=1;
            Console.Write("What is your guess? ");
           string userInput = Console.ReadLine();
           guessNumber = int.Parse(userInput); 
           
           //Using an if statement, determine if the user needs to guess higher or lower next time, or tell them if they guessed it. 
                    if (guessNumber < magicNumber) {
                    Console.WriteLine("Higher");
            } 
                      else if (guessNumber > magicNumber) {
                       Console.WriteLine("Lower");
            } 
                      else  {
                      Console.WriteLine($"You guessed it! you did it in {countGuesses} count");
            } 
            } 
                 Console.Write("Do you want to play again? ");
                response = Console.ReadLine(); 
            } 
             
               if(response == "yes") {
                    play = true;
                }
                
            
        }  
        }