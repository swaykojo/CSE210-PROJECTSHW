using System;

class Program
    {
        static void Main(string[] args)
        {   
            DisplayWelcome();

            string nameUser = PromptUserName();
            int numberFavorite = PromptUserNumber();
            int numberSquare = SquareNumber(numberFavorite);

            DisplayResult(numberSquare, nameUser);

            //DisplayWelcome - Displays the message, "Welcome to the Program!" 
            static void DisplayWelcome() {
                Console.WriteLine("Welcome to the Program!"); 
            } 
            
            // PromptUserName - Asks for and returns the user's name (as a string)
            static string PromptUserName() {
                Console.Write("Enter your name: ");
                string userName = Console.ReadLine();

                return userName; 
            } 
            
            // PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
            static int PromptUserNumber() {
                Console.Write("Enter your favorite number: ");
                string userInput = Console.ReadLine();
                int favoriteNumber = int.Parse(userInput); 

                return favoriteNumber;
            } 
            
            // SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
            static int SquareNumber(int number) { 
                int square = number * number;

                return square;
            } 
            
            // DisplayResult - Accepts the user's name and the squared number and displays them.
            static void DisplayResult(int square, string userName) {
                Console.WriteLine($"{userName}, the square of your number is {square}");
            }
           
    }
} 