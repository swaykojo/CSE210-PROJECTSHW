using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");

        Running run = new Running("03 Nov 2022", 30, 3);
        Console.WriteLine(run.GetSummary());

        Cycling cycle = new Cycling("15 May 2022", 54, 14);
         Console.WriteLine(cycle.GetSummary());

         Swimming swim = new Swimming("13 Sep 2022", 12, 4);
         Console.WriteLine(swim.GetSummary());

    }
}