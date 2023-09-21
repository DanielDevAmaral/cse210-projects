using System;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new();
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2021;
        job1._endYear = 2023;
        job1._company = "Microsoft";


        Job job2 = new();
        job2._jobTitle = "Software Engineer Sr.";
        job2._startYear = 2021;
        job2._endYear = 2023;
        job2._company = "Apple";


        Resume myResume = new();
        myResume._personName = "Daniel Amaral";

        myResume.jobs.Add(job1);
        myResume.jobs.Add(job2);

        myResume.Display();
    }
}


