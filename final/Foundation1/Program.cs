using System;

class Program
{
    static void Main(string[] args)
    {
        Video pancakes = new("How make Pancakes", "Daniel Amaral", 56.8);
        Comment pancakesVideo = new("Zezinho", "gostei não disso não");
        Comment pancakesVideo2 = new("MyWife", "I liked");
        Comment pancakesVideo3 = new("Nobody", ".....");
        Comment pancakesVideo4 = new("Guy", "That is nice");
        pancakes.ListOfComments(pancakesVideo);
        pancakes.ListOfComments(pancakesVideo2);
        pancakes.ListOfComments(pancakesVideo3);
        pancakes.ListOfComments(pancakesVideo4);
        pancakes.Display();
        Console.WriteLine();

        Video Marshmellow = new("How toast Marshmellow", "Israel Murati", 1000.5);
        Comment comment1 = new("anonymmous", "that is a good recipe");
        Comment comment2 = new("Danny Phanton", "Ghosting....");
        Comment comment3 = new("Ana Maria Braga", "The halloween already have the table");
        Comment comment4 = new("anonymmous", "Could be better");
        Marshmellow.ListOfComments(comment1);
        Marshmellow.ListOfComments(comment2);
        Marshmellow.ListOfComments(comment3);
        Marshmellow.ListOfComments(comment4);
        Marshmellow.Display();
         Console.WriteLine();

        Video building = new("How Build a Castle in the Florest", "Two Guys Without T-Shirt", 1580.4);
        Comment comment5 = new("anonymmous", "Lets Build!!!!!!!!!!!");
        Comment comment6 = new("The Boy how see", "I see a lot of machines behind the tree");
        Comment comment7 = new("???", "Try with tools");
        Comment comment8 = new("Jake, the dog", "Auw Auw");
        building.ListOfComments(comment5);
        building.ListOfComments(comment6);
        building.ListOfComments(comment7);
        building.ListOfComments(comment8);
        building.Display();



    }
}