using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1.jobTitle = "Software Engineer";
        job1.companyName = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2.jobTitle = "Manager";
        job2.companyName = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

       Resume myResume = new Resume();
       myResume._name = "Allison Rose";
       myResume._jobs.Add(job1);
       myResume._jobs.Add(job2);

       myResume.Display();
    }
}