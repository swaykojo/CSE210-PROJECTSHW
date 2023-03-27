using System;

public class Square : Shape
{
    private double _side;

    public Square(string color, double side) : base(color)
    {
        _side = side;
    }
    public double Getside() 
    {
        return _side;
    } 

    public void Setside(double side) 
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}