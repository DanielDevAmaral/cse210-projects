using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        Console.Write("What is your guess? ");
        string number_guess_str = Console.ReadLine();
        int number_guess = int.Parse(number_guess_str);


            while (number_guess != number)
            {
            if (number_guess > number)
            {
                    Console.WriteLine("Lower");
                    Console.Write("What is your guess? ");
                    number_guess_str = Console.ReadLine();
                    number_guess = int.Parse(number_guess_str);
            }
            else if (number_guess == number)
            {
                Console.Write("You guessed it!");
            }
            else
            {
                    Console.WriteLine("Higher");
                    Console.Write("What is your guess? ");
                    number_guess_str = Console.ReadLine();
                    number_guess = int.Parse(number_guess_str);
            }
            }
    }
}