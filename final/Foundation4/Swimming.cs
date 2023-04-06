using System; 

public  class Swimming : Activity
{
    private int _laps;
    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _type = "Swimming";
        _laps = laps;
        
    }

    public override double GetDistance()
    {
        return Math.Round(Convert.ToDouble(_laps) * 50/ 1000 * 0.62, 2);
    }

    public override double GetSpeed()
    {
        return Math.Round(60/GetPace(), 2);
    }

    public override double GetPace()
    {
        return Math.Round(Convert.ToDouble(_minutes) / GetDistance(), 2);
    }
}