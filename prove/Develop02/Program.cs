using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        static void Displaymenu()
        {
                    Console.WriteLine(@"
1. Write
2. Display
3. Load
4. Save
5. Quit");

        Console.Write("What would you like to do? ");
        }

        string choose = "";
        Journal myJournal = new();


    while (choose != "5") //Break
    {

        Displaymenu();
        choose = Console.ReadLine();

        if (choose == "1") // Write
        {
        PromptGenerator write = new();
        write._prompts = new List<string>
        {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
        };

        Entry myEntry = new();
        myEntry._promptText = write.GetRandomPrompt();
        Console.WriteLine(myEntry._promptText);

        string newEntry = Console.ReadLine();
        myEntry._entryText = newEntry;
        myJournal._entries.Add(myEntry);

        } 

        else if (choose == "2") // Display
        {
        myJournal.DisplayAll();
        }

        else if (choose == "3")  // Load
        {
            Console.Write("Write the name of the file: ");
            string nameFileLoad = Console.ReadLine();
            myJournal.LoadFromFile(nameFileLoad);
        } 
        
        else if (choose == "4")  // Save
        {
            Console.Write("Write the name for your file: ");
            string nameFile = Console.ReadLine();
            myJournal.SaveToFile($"{nameFile}");
        } 

        else if (choose == "5")  // Quit
        {
            Console.Write("Bye!!");
        }
        
        else // Invalid Entry
        {
          Console.WriteLine("That is a invalid enter, please select the options between 1-5.");
        }
    }

    }
}