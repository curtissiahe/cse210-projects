using System;

// Base class for all types of goals
public class Goal
{
    public string Name { get; set; }
    public bool Completed { get; set; }

    public Goal(string name)
    {
        Name = name;
        Completed = false;
    }

    public virtual void RecordEvent()
    {
        Completed = true;
    }

    public virtual string GetDetailsString()
    {
        return $"Goal: {Name}\tStatus: {(Completed ? "Completed" : "Not Completed")}";
    }
}
