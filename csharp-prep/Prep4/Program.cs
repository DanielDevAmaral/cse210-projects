using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter number: ");
        string number_str = Console.ReadLine();
        int number = int.Parse(number_str);

        if (number != 0)
        {
            numbers.Add(number);
        }

        int sum = 0;
        int avarage = 0;

        while(number != 0) 
        {
            Console.Write("Enter number: ");
            number_str = Console.ReadLine();
            number = int.Parse(number_str);
            numbers.Add(number);
        }
            
        foreach (int number_list in numbers)
        {
            sum += number_list;
        }
        Console.WriteLine($"The sum is: {sum}");

        for (int i = 0; i < numbers.Count; i++)
        {
        avarage = sum / numbers.Count;
        }
        Console.WriteLine($"The average is: {avarage}");

        int largest = numbers.Max();
        Console.WriteLine($"The largest number is: {largest}");

    }
}