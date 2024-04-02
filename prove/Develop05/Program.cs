using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        while (true)
        {
            Console.WriteLine("\n---Eternal Quest Program---");
            Console.WriteLine("1. Add a new goal");
            Console.WriteLine("2. Record event for a goal");
            Console.WriteLine("3. Display goals");
            Console.WriteLine("4. Display total score");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddNewGoal(goalManager);
                    break;
                case "2":
                    RecordEventForGoal(goalManager);
                    break;
                case "3":
                    goalManager.DisplayGoals();
                    break;
                case "4":
                    Console.WriteLine($"Total Score: {goalManager.CalculateTotalScore()} points");
                    break;
                case "5":
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }
        }
    }

    static void AddNewGoal(GoalManager goalManager)
    {
        Console.WriteLine("\n---Add a new goal---");
        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();

        Console.Write("Select the type of goal (1. Simple, 2. Eternal, 3. Checklist): ");
        string typeChoice = Console.ReadLine();

        switch (typeChoice)
        {
            case "1":
                Console.Write("Enter the points for completing the goal: ");
                int points = int.Parse(Console.ReadLine());
                goalManager.AddGoal(new SimpleGoal(name, points));
                break;
            case "2":
                Console.Write("Enter the points for each recording of the goal: ");
                int eternalPoints = int.Parse(Console.ReadLine());
                goalManager.AddGoal(new EternalGoal(name, eternalPoints));
                break;
            case "3":
                Console.Write("Enter the points for each completion of the goal: ");
                int checklistPoints = int.Parse(Console.ReadLine());
                Console.Write("Enter the required completions for the goal: ");
                int requiredCompletions = int.Parse(Console.ReadLine());
                goalManager.AddGoal(new ChecklistGoal(name, checklistPoints, requiredCompletions));
                break;
            default:
                Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                break;
        }
    }

    static void RecordEventForGoal(GoalManager goalManager)
    {
        Console.WriteLine("\n---Record event for a goal---");
        Console.Write("Enter the name of the goal: ");
        string goalName = Console.ReadLine();
        goalManager.RecordEventForGoal(goalName);
    }
}
