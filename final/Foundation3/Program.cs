using System;

class Program
{
    static void Main(string[] args)
       {
        Address address1 = new Address("123 Main St", "Cityville", "Stateville", "12345");
        Address address2 = new Address("456 Elm St", "Townville", "Stateville", "67890");
        Address address3 = new Address("789 Oak St", "Villageville", "Stateville", "54321");

        DateTime date1 = DateTime.Parse("2023-11-15");
        DateTime date2 = DateTime.Parse("2023-12-10");
        DateTime date3 = DateTime.Parse("2023-10-25");

        Event genericEvent = new Event("Generic Event", "A generic event", date1, "3:00 PM", address1);
        Lecture lectureEvent = new Lecture("Tech Talk", "Exciting tech discussion", date2, "2:00 PM", address2, "John Doe", 50);
        Reception receptionEvent = new Reception("Networking Night", "Join us for networking", date3, "7:00 PM", address3, "info@example.com");
        OutdoorGathering outdoorEvent = new OutdoorGathering("Picnic in the Park", "Fun outdoor gathering", date1, "11:00 AM", address1, "Weather: Sunny and 75°F");

        Console.WriteLine("Standard Details:");
        Console.WriteLine(genericEvent.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorEvent.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine(genericEvent.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorEvent.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description:");
        Console.WriteLine(genericEvent.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(lectureEvent.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(receptionEvent.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(outdoorEvent.GetShortDescription());
    }
}