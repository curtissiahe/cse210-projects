using System;
using System.Threading;

class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _duration = 60; // Default duration: 60 seconds
    }

    public override void Run()
    {
        base.Run();
        
        Console.WriteLine("Starting breathing activity...");
        Console.WriteLine("Breathe in...");
        Thread.Sleep(1000); // Pause for 1 second
        Console.WriteLine("Breathe out...");
        Thread.Sleep(1000); // Pause for 1 second

        // Continue breathing for the specified duration
        for (int i = 0; i < _duration - 2; i += 2)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(1000); // Pause for 1 second
            Console.WriteLine("Breathe out...");
            Thread.Sleep(1000); // Pause for 1 second
        }

        DisplayEndingMessage();
    }
}
