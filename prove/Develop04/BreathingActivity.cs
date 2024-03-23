using System;
using System.Threading;

// Breathing activity
public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity(int durationInSeconds) : base(durationInSeconds) { }

    public override void Start()
    {
        Console.WriteLine("\nBreathing Activity");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly.");
        Console.WriteLine("Clear your mind and focus on your breathing.");
        Console.WriteLine("Duration: " + durationInSeconds + " seconds.");
        Thread.Sleep(5000); // Pause for preparation

        for (int i = 0; i < durationInSeconds; i += 2)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(1000);
            Console.WriteLine("Breathe out...");
            Thread.Sleep(1000);
        }

        EndActivity("Breathing Activity");
    }
}
