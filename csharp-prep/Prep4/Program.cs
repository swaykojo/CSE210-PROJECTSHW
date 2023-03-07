using System;

class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Prep 4");
            
            Console.WriteLine("Enter a list of numbers, type 0 when finished."); 

            List<int> numbers = new List<int>(); 
            
            int userNumber = -1;  

            int sumTotal = 0;
            
            int lengthList = 0; 

            int maxValue = 0; 

            int smallestPositive = 0;

            while (userNumber != 0) { 
                Console.Write("Enter number: ");
                string userInput = Console.ReadLine();
                userNumber = int.Parse(userInput); 

                if (userNumber > 0) {
                    numbers.Add(userNumber);
                }   
            } 
            
            foreach(int number in numbers) { 
                sumTotal += number; 

                if (maxValue < number){
                    maxValue = number;
                } 

                if (number > 0) {
                    smallestPositive = number;
                }
            } 
             lengthList = numbers.Count;   
            float average = ((float)sumTotal)/ lengthList; 
            
            
              Console.WriteLine($"The sum is: {sumTotal}"); 
              Console.WriteLine($"The average is: {average}"); 
              Console.WriteLine($"The largest number is: {maxValue}"); 
              Console.WriteLine($"The smallest positive number is: {smallestPositive}"); 
              Console.WriteLine("The sorted list is:");
        }         
    }