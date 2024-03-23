using System;
using System.Threading;

// Base class for mindfulness activity
public abstract class MindfulnessActivity
{
    protected int durationInSeconds;

    public MindfulnessActivity(int durationInSeconds)
    {
        this.durationInSeconds = durationInSeconds;
    }

    public abstract void Start();

    // Common ending message for all activities
    protected void EndActivity(string activityName)
    {
        Console.WriteLine("\nGreat job! You have completed the " + activityName + ".");
        Console.WriteLine("Total duration: " + durationInSeconds + " seconds.");
        Thread.Sleep(3000);
    }
}
