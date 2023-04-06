using System;

public  abstract class Activity 
{
    protected string _date;

    protected  int _minutes;

    protected double _speed, _pace, _distance;

    protected string _type;


    protected Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    } 

    public virtual double GetSpeed()
    {
        return _speed;
    } 

    public virtual double GetDistance()
    {
        return _distance;
    } 

    public virtual double GetPace() 
    {
        return _pace;
    } 

    public virtual string GetSummary()
    {
        return $"{_date} {_type} ({_minutes}min)- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace {GetPace()} per mile)";
    }
}