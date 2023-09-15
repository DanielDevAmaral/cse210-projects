using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResult(name, square);
    }


    static void DisplayWelcome ()
    {
    Console.WriteLine($"Welcome to the Program!");
    }

    static string PromptUserName ()
    {
    Console.Write($"Please enter your name: ");
    string name = Console.ReadLine();
    return name;
    }

    static int PromptUserNumber ()
    {
    Console.Write($"Please enter your favorite number: ");
    string number_str = Console.ReadLine();
    int number = int.Parse(number_str);
    return number;
    }

    static int SquareNumber (int number)
    {
    int square = number * number;
    return square;
    }

    static void DisplayResult (string name, int number)
    {
        Console.Write($"Brother {name}, the square of your number is {number} ");
    }
}