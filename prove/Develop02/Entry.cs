
class Entry
{

    private string _prompt;
    private string _response;
    private string _date;

    public Entry(string date, string prompt, string response)
    {
        _prompt = prompt;
        _response = response;
        _date = date;


    }
    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}  Response:{_response}");


    }
    public string getEntryAsCSV()
    {
        return string.Format("{0}|{1}|{2}", _date, _prompt, _response);
    }

}
