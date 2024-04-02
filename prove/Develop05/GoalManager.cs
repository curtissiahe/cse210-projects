using System;
using System.Collections.Generic;

// Class to manage goals
public class GoalManager
{
    private List<Goal> goals;

    public GoalManager()
    {
        goals = new List<Goal>();
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEventForGoal(string goalName)
    {
        foreach (var goal in goals)
        {
            if (goal.Name == goalName)
            {
                goal.RecordEvent();
                return;
            }
        }
        Console.WriteLine("Goal not found.");
    }

    public void DisplayGoals()
    {
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public int CalculateTotalScore()
    {
        int totalScore = 0;
        foreach (var goal in goals)
        {
            if (goal.Completed)
            {
                if (goal is SimpleGoal || goal is EternalGoal)
                {
                    totalScore += ((SimpleGoal)goal).Points;
                }
                else if (goal is ChecklistGoal)
                {
                    totalScore += ((ChecklistGoal)goal).PointsPerCompletion * ((ChecklistGoal)goal).CurrentCompletions;
                    if (((ChecklistGoal)goal).CurrentCompletions == ((ChecklistGoal)goal).RequiredCompletions)
                    {
                        totalScore += 500; // Bonus points
                    }
                }
            }
        }
        return totalScore;
    }
}
