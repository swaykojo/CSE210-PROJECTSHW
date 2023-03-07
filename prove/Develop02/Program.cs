using System;

class Program
{
    static void Main(string[] args)
    {

        Journal myjournal = new Journal();
        int userResponse = 0;

        List<string> menu = new List<string> {
                "Please slect one of the following choices:",
                "1. Write",
                "2. Display",
                "3. Load",
                "4. Save",
                "5. Quit",
                "What would you like to do? "
        };

        while (userResponse != 5)
        {
            foreach (string menuList in menu)
            {
                Console.WriteLine(menuList);
            }
            userResponse = int.Parse(Console.ReadLine());

            if (userResponse == 1)
            {
                myjournal.CreateJournalEntry();
            }
            else if (userResponse == 2)
            {
                myjournal.DisplayJournalEntries();
            }
            else if (userResponse == 3)
            {
                myjournal.LoadFromCSV();
            }
            else if (userResponse == 4)
            {

                myjournal.SaveToCSV();
            }

        }
    }
}