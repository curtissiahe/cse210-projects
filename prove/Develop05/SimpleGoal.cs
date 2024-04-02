using System;

// Derived class for simple goals
public class SimpleGoal : Goal
{
    public int Points { get; set; }

    public SimpleGoal(string name, int points) : base(name)
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
