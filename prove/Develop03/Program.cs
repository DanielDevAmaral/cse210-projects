using System;

class Program
{
    static void Main(string[] args)
    {
        Reference myReference = new("John", 3, 4, 5);
        Scripture myScripture = new("Nicodemus saith unto him, How can a man be born when he is old? can he enter the second time into his mother’s womb, and be born? Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God.", myReference);
        
        Console.Clear();

        while (!myScripture.IsCompletelyHidden())
        {
            Console.WriteLine(myScripture.GetDisplayText());

            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            myScripture.HideRandomWords(5);
            Console.Clear();
        }

        Console.WriteLine("I hope that you memorize the scripture!");
    }
    }
