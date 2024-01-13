using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade: ");
        string grade = Console.ReadLine();
        int numberGrade = int.Parse(grade);
        string letter = "";
        string sign = "";
        if (numberGrade >= 90)
        {
            letter = "A";
        }
        else if (numberGrade >= 80)
        {
            letter = "B";
        }
        else if (numberGrade >= 70)
        {
            letter = "C";
        }
        else if (numberGrade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        if (numberGrade % 10 >= 7)
        {
            sign = "+";
        }
        else if (numberGrade % 10 < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        if (numberGrade >= 93)
        {
            sign = "";
        }

        if (letter == "F")
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (numberGrade >= 70)
        {
            Console.WriteLine("Congratulations! you passed");
        }
        else
        {
            Console.WriteLine("Put more efforts next time");
        }
    }
}