using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {


        Rectangle rectangle = new(4.1,8.4, "blue");
        Square square = new(4.2, "grey");
        Circle circle = new(4,"yellow");
        
        List<Shape> lista = new List<Shape>();
        lista.Add(square);
        lista.Add(rectangle);
        lista.Add(circle);

        foreach(Shape itens in lista)
        {
            Console.WriteLine(itens.GetArea());
            Console.WriteLine(itens.GetColor());
        }

    }
}