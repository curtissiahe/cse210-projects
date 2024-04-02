using System;

// Derived class for eternal goals
public class EternalGoal : Goal
{
    public int Points { get; set; }

    public EternalGoal(string name, int points) : base(name)
    {
        Points = points;
    }

    public override void RecordEvent()
    {
        base.RecordEvent();
        Console.WriteLine($"Event recorded for {Name}. You gained {Points} points.");
    }

    public override string GetDetailsString()
    {
        return base.GetDetailsString() + $"\tPoints: {Points}";
    }
}
