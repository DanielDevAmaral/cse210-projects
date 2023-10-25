using System;

class Program
{
    static void Main(string[] args)
    {
         List<Activity> activities = new List<Activity>
        {
            new Running(DateTime.Parse("2022-11-03"), 30, 3.0),
            new Running(DateTime.Parse("2022-11-03"), 30, 4.8),
            new StationaryBicycle(DateTime.Parse("2022-11-04"), 45, 20.0),
            new Swimming(DateTime.Parse("2022-11-05"), 60, 30),
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}