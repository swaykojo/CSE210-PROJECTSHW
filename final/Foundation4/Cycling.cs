using System; 

public  class Cycling : Activity
{
    
    public Cycling(string date, int minutes, double speed) : base(date, minutes)
    {
        _type = "Cycling";
        _speed = speed;
    }

    public override double GetDistance() 
    { 
        double test = (_minutes/ 60)*_speed;
        return (Convert.ToDouble(_minutes)/ 60)*_speed;
    }

    public override double GetPace()
    {
        return Math.Round(60/_speed,2);
    }
}