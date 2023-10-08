using System;

class Program
{
    static void Main(string[] args)
    {
        //degreeAudit object
        Assignments degreeAudit = new("Daniel Amaral", "Matemática");
        Console.WriteLine(degreeAudit.GetSummary()); 


        //myAssignment object
        MathAssignment myAssignment = new("Emilia Amaral", "Medicina","7.3", "8-19");
        Console.WriteLine(myAssignment.GetSummary());       
        Console.WriteLine(myAssignment.GetHomeworkList());


        //writingAssignment object
        WritingAssignment writingAssignment = new("Izabele Amaral", "Enfermagem","History of the xesq and desq");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.Write(writingAssignment.GetWritingInformation());
    }
}