using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Process Engineer";
        job1._company = "Dangote Refinery";
        job1._startYear = 2020;
        job1._endYear = 2022;
        job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._jobTitle = "Software Developer";
        job2._company = "Andela";
        job2._startYear = 2016;
        job2._endYear = 2020;
        job2.DisplayJobDetails();

        Resume myResume = new Resume();
        myResume._name = "Ebigide Jude";
        myResume._resume.Add(job1);
        myResume._resume.Add(job2);

        myResume.Display();

        
    }
}