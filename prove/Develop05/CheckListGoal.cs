using System;

public class CheckListGoal : Goal
{
      private const int goalType = 3;

      private int _goalTimes;

      private int _goalBonus;

   private bool goalComplete;

   public CheckListGoal()
   {
   }

   public CheckListGoal(string _goalName, string _goalDescription, int _goalPoints, int goalTimes, int goalBonus, bool _goalComplete) : base (_goalName, _goalDescription, _goalPoints)
   {
    goalComplete = _goalComplete;
    _goalBonus = goalBonus;
    _goalTimes = goalTimes;
   } 

   public int GetGoalTimes() 
   {
        return _goalTimes;
   } 

   public void SetGoalTimes(int goalTimes)
   {
      _goalTimes = goalTimes;
   } 

   public int GetGoalBonus()
   {
     return _goalBonus;
   } 

   public void SetGoalBonus(int goalBonus)
   {
     _goalBonus = goalBonus;
   } 

   public void DisplayGetGoalTimes()
   {
     Console.Write("How many times does this goal need to be accomplished for a bonus? ");
     _goalTimes = int.Parse(Console.ReadLine());
   } 
    public void DisplayGetGoalBonus()
    {
        Console.Write("What is the bonus for accomplishing it has that many times? ");
        _goalBonus = int.Parse(Console.ReadLine());
    }

   public override string ToCSVRecord()
   {
      return string.Format("{0}|{1}|{2}|{3}|{4}", goalType, GetGoalName(), GetGoalDescription(), GetGoalPoints(), goalComplete);
   }

    public override string ToString()
    {
        return string.Format("[{0}] {1} ({2})", ((goalComplete == false) ? " ": "X"), GetGoalName(), GetGoalDescription());
    } 

    public override void RecordEvent()
    {
        Console.WriteLine(string.Format("Congratulations! You have earned {0}", GetGoalPoints()));
        goalComplete = true;
} 
}