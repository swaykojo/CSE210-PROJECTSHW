using System.IO;
class Journal
{
    List<Entry> entries;

    PromptGenerator mypromptGenerator = new PromptGenerator();
    public Journal()
    {
        entries = new List<Entry>();

    }

    public void DisplayJournalEntries()
    {
        foreach (Entry entry in entries)
        {
            entry.DisplayEntry();
        }

    }
    public void CreateJournalEntry()
    {
        string myprompt = mypromptGenerator.GetRandomPrompt();
        Console.WriteLine(myprompt);
        string userInput = Console.ReadLine();

        Entry myEntry = new Entry(DateTime.Now.ToShortDateString(), myprompt, userInput);
        entries.Add(myEntry);
    }

    public void SaveToCSV()
    {
        Console.Write("Enter Filename: ");
        string filename = Console.ReadLine();
        //Open a file 
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // Go through my entries, one by one.
            foreach (Entry myentry in entries)
            {

                // Get a string that represents this entry (inculding all aparts of it) 
                outputFile.WriteLine(myentry.getEntryAsCSV());


            }
        }

    }

    public void LoadFromCSV()
    {
        Console.Write("Enter Filename: ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {

            string[] parts = line.Split("|");

            Entry newentry = new Entry(parts[0], parts[1], parts[2]);
            entries.Add(newentry);
        }




    }
}