using System;
using System.Collections.Generic;
using System.Threading;

class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        // Add more questions as needed
    };

    public ReflectionActivity()
    {
        _name = "Reflection";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _duration = 120; // Default duration: 120 seconds
    }

    public override void Run()
    {
        base.Run();

        Console.WriteLine("Starting reflection activity...");
        
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine($"Prompt: {prompt}");

        foreach (string question in _questions)
        {
            Console.WriteLine(question);
            Thread.Sleep(2000); // Pause for 2 seconds
            Console.WriteLine("Showing spinner...");
            Thread.Sleep(1000); // Pause for 1 second
        }

        DisplayEndingMessage();
    }
}
