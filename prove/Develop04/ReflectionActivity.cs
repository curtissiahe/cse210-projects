using System;
using System.Threading;

// Reflection activity
public class ReflectionActivity : MindfulnessActivity
{
    public ReflectionActivity(int durationInSeconds) : base(durationInSeconds) { }

    public override void Start()
    {
        Console.WriteLine("\nReflection Activity");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience.");
        Console.WriteLine("This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine("Duration: " + durationInSeconds + " seconds.");
        Thread.Sleep(5000); // Pause for preparation

        string[] prompts = {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        Random random = new Random();
        for (int i = 0; i < durationInSeconds; i += 10)
        {
            string prompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine("Prompt: " + prompt);

            // Simulating reflection questions
            // You can add more questions as needed
            string[] questions = {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?"
            };

            foreach (string question in questions)
            {
                Console.WriteLine("Question: " + question);
                Thread.Sleep(3000); // Pause for reflection
            }
        }

        EndActivity("Reflection Activity");
    }
}
