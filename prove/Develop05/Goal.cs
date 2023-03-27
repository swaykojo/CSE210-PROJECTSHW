using System;

public abstract class Goal 
{
    private string _goalName;
    private string _goalDescription;

    private int _goalPoints; 

    public Goal()
    {

    }

    public Goal(string goalName, string goalDescription, int goalPoints) 
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;
    }
    public string GetGoalName()
    {
        return _goalName;
    } 

    public void SetGoalName(string goalName)
    {
       _goalName = goalName;
    } 

    public string GetGoalDescription()
    {
        return _goalDescription;
    } 
    public void SetGoalDescription(string goalDescription) 
    {
        _goalDescription = goalDescription;
    } 

    public int GetGoalPoints()
    {
        return _goalPoints;
    } 

    public void SetGoalPoints(int goalPoints)
    {
        _goalPoints = goalPoints;
    } 

    public void DisplayGetGoalName()
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
    } 

    public void DisplayGetGoalDescription()
    {
        Console.Write("What is a short description of it? ");
        _goalDescription = Console.ReadLine();
    } 

    public void DisplayGetGoalPoints()
    {
        Console.Write("what is the amount of points associated with this goal? ");
        _goalPoints = int.Parse(Console.ReadLine());
    }

    public abstract string ToCSVRecord();

    public abstract override string ToString();
    

    public abstract void RecordEvent();
}