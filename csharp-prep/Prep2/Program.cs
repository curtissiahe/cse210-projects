using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your name");
        string name =Console.ReadLine();
        Console.WriteLine($"What is your current mark {name}");
        string reply= Console.ReadLine();
        int grade=int.Parse(reply);

        if (grade>=90)
        {
            if (grade>95)
             {
            Console.WriteLine($"Your grade is A+ good job {name}.");

             }
             else
             {
                Console.WriteLine($"Your grade is A- good job {name}.");

             }

        }

       
        else if (grade>=80)
        {
            if (grade>85)
            {
                Console.WriteLine($"nice one bro B+");
            }
            else
            {
                Console.WriteLine($"nice one bro B_");
            }
        
    
        
        }
        else if (grade>=70)
        {
            Console.WriteLine("not to bad you had C");
        }
        else if (grade>=60)
        {
            Console.WriteLine("you need to work hard you got a D");
        }
        else 
        {
            Console.WriteLine("you did not work at all, got F shame on you");
        }



    }
}