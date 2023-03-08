using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!"); 

        Fraction fraction = new Fraction(); 
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());

        Fraction fraction1 = new Fraction(5);
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Fraction fraction2 = new Fraction(10, 5); 
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

    }
}