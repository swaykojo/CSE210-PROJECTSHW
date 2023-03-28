using System;

class Program
{
    static void Main(string[] args)
    { 
        AllGoals allGoals = new AllGoals();
       int userMainMenu = 0;

       while(userMainMenu != 6)
       { 
        Menu menu1 = new Menu();
        Console.WriteLine();
        menu1.DisplayPoints(allGoals.getTotalPoints());
        menu1.DisplayMainMenu();
        userMainMenu = menu1.DisplayGetMainMenu();

         if(userMainMenu == 1) 
         {
            int userNewGoalMenu = menu1.DisplayGetCreateNewGoalMenu();
            Goal goal = null;
            if(userNewGoalMenu == 1) 
            {
                goal = new SimpleGoal();
                goal.DisplayGetGoalName();
                goal.DisplayGetGoalDescription();
                goal.DisplayGetGoalPoints();
                
                if (goal != null)
            {
                allGoals.addGoal(goal);
            }

            }  

            else if(userNewGoalMenu == 2) 
            {
                goal = new EternalGoal();
                goal.DisplayGetGoalName();
                goal.DisplayGetGoalDescription();
                goal.DisplayGetGoalPoints();

                if (goal != null)
            {
                allGoals.addGoal(goal);
            }

            }

            else if(userNewGoalMenu == 3) 
            { 
                CheckListGoal check = new CheckListGoal();
                goal = new CheckListGoal();
                goal.DisplayGetGoalName();
                goal.DisplayGetGoalDescription();
                goal.DisplayGetGoalPoints();
                check.DisplayGetGoalTimes();
                check.DisplayGetGoalBonus();

                if (goal != null)
            {
                allGoals.addGoal(goal);
            }

            }
            
         } 
         else if (userMainMenu == 2)
         {
            allGoals.DisplayGoals();
         } 
         else if(userMainMenu == 3)
         {
            allGoals.SaveGoals();
         } 
         else if(userMainMenu == 4)
         {
            allGoals.LoadGoals();
         } 
         else if(userMainMenu == 5)
         {
            allGoals.DisplayGoalsRecordEvent();
         }
       }

    }
} 
