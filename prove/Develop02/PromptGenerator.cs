using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> prompts;

    public PromptGenerator()
    {
        // Initialize the list of prompts
        prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            // Add more prompts as needed
        };
    }

    public string GetRandomPrompt()
    {
        // Create a random number generator
        Random rand = new Random();

        // Get a random prompt
        return prompts[rand.Next(prompts.Count)];
    }
}
