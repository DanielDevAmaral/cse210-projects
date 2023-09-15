using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string user_grade = Console.ReadLine();
        int grade = int.Parse(user_grade);

        string letter = "NaN";

        if (grade >= 90) 
        {
            letter = "A";
            Console.WriteLine("Congrats! You did it!");
        }
        else if (grade >= 80)
        {
            letter = "B";
            Console.WriteLine("Congrats! You did it!");
        }
        else if (grade >= 70)
        {
            letter = "C";
            Console.WriteLine("Congrats! You did it!");
        }
        else if (grade >= 60)
        {
            letter = "D";
            Console.WriteLine("Sorry, but your grade do not complete the requirements");
        }
        else if (grade < 60)
        {
            letter = "F";
            Console.WriteLine("Sorry, but your grade do not complete the requirements");
        }

        Console.WriteLine($"{letter}");
        
    }
}