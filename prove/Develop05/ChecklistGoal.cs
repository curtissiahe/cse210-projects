using System;

// Derived class for checklist goals
public class ChecklistGoal : Goal
{
    public int PointsPerCompletion { get; set; }
    public int RequiredCompletions { get; set; }
    public int CurrentCompletions { get; set; }

    public ChecklistGoal(string name, int pointsPerCompletion, int requiredCompletions) : base(name)
    {
        PointsPerCompletion = pointsPerCompletion;
        RequiredCompletions = requiredCompletions;
        CurrentCompletions = 0;
    }

    public override void RecordEvent()
    {
        base.RecordEvent();
        CurrentCompletions++;
        int totalPoints = PointsPerCompletion * CurrentCompletions;
        if (CurrentCompletions == RequiredCompletions)
        {
            totalPoints += 500; // Bonus points on completion
            Console.WriteLine($"Congratulations! You completed {Name} {RequiredCompletions} times and gained a bonus of 500 points.");
        }
        else
        {
            Console.WriteLine($"Event recorded for {Name}. You gained {PointsPerCompletion} points.");
        }
    }

    public override string GetDetailsString()
    {
        return base.GetDetailsString() + $"\tCompleted: {CurrentCompletions}/{RequiredCompletions}";
    }
}
