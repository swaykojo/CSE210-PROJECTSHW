using System; 

public class EternalGoal : Goal
{ 
     private const int goalType = 2;

   private bool goalComplete;

   public EternalGoal()
   {
   }

   public EternalGoal(string _goalName, string _goalDescription, int _goalPoints, bool _goalComplete) : base (_goalName, _goalDescription, _goalPoints)
   {
    goalComplete = _goalComplete;
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