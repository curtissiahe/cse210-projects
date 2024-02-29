using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> collections = new List<int>();

        int number;
        int sum = 0;
        do
        {
            Console.WriteLine("Enter number:");
            string input = Console.ReadLine();
            number = int.Parse(input);

            if (number != 0)
            {
                collections.Add(number);
            }

        } while (number != 0);

        Console.WriteLine("Numbers entered:");
        foreach (int num in collections)
        {
            Console.WriteLine(num);
            sum += num; // Accumulating sum here
        }
        Console.WriteLine($"Number of elements: {collections.Count}"); // Printing count after the loop

        double average = (double)sum / collections.Count; // Calculating average
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");

        // Finding the largest number
        int maxNumber = collections[0]; // Initialize maxNumber with the first element of the list
        for (int i = 1; i < collections.Count; i++)
        {
            if (collections[i] > maxNumber)
            {
                maxNumber = collections[i];
            }
        }
        Console.WriteLine($"The largest number in the list is: {maxNumber}");
    }
}
