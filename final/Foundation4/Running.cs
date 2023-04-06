using System;

public class Running : Activity
{
    

 

    public Running( string date, int minutes, int distance) : base(date, minutes)
    {
       _type = "Running";
       _distance = distance;
    }

    public override double GetSpeed()
    {
        return (_distance / _minutes) * 60;
    }

    public override double GetPace()
    {
        return (60 / GetSpeed());
    }
}