using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment firstAssg = new Assignment("Ebigide Jude", "Multiplication");
        string summary = firstAssg.GetSummary();
        Console.WriteLine(summary);
        
        MathAssignment mathematics = new MathAssignment("Ebigide Jude", "Algebra", "5.2", "6-12");
        Console.WriteLine(mathematics.GetSummary());
        Console.WriteLine(mathematics.GetHomeworkList());

        WritingAssignment writing = new WritingAssignment("Ebigide Jude", "Nigerian History", "The Joy of Independence day");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}