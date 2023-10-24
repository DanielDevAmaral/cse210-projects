using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new("Bicycle", 23851, 2, 87.0);
        Product product2 = new("Motocycle", 23851, 1, 487.5);
        Address addressP = new("ligth street", "New York", "USA");
        Customer paulo = new("Paulo Mortence", addressP);
        Order firstOrder = new();

        firstOrder.Display();


    }
}