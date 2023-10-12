using System;

class Program
{
    static void Main(string[] args)
    {
        static void Menu()
        {
        Console.Clear();
        Console.WriteLine($"\nMenu Options:\n");
        Console.WriteLine($"1. Start breathing activity");
        Console.WriteLine($"2. Start reflecting activity");
        Console.WriteLine($"3. Start listing activity");
        Console.WriteLine($"4. Quit");
        Console.Write($"\nSelect a choice from the menu: ");
        }

        Menu();

        int userInput = int.Parse(Console.ReadLine());

        while (userInput != 4)
        {
         if(userInput == 1)
         {
        
            BreathingActivity breathingActivity = new();
            breathingActivity.Run();
            Menu();
            userInput = int.Parse(Console.ReadLine());
        }
        
        else if (userInput ==2)
        {

            ReflectingActivity reflectingActivity = new();
            reflectingActivity.Run();
            Menu();
            userInput = int.Parse(Console.ReadLine());
        }

        else if (userInput == 3)
        {

            ListiningActivity listiningActivity = new();
            listiningActivity.Run();
            Menu();
            userInput = int.Parse(Console.ReadLine());
        }
        }   

    }
}



