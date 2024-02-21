using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("Bogije", "Ibeju-Lekki", "Lagos", "Nigeria");

        Lecture lecture = new Lecture("Literary Reading: 'A Perfect Short Story'", "An evening of literary", "November 29, 2023", "9 AM", address, "Valeria Alcala", 120);
        Console.WriteLine();

        Console.WriteLine("Event Number: 1");
        Console.WriteLine();
        Console.WriteLine(lecture.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(lecture.GenerateDetailedLecture());

        Console.WriteLine();
        Console.WriteLine(lecture.GenerateShortLecture());

        Address addressR = new Address("Lekki", "Yaba Stake", "Lagos", "Nigeria");

        Reception reception = new Reception("Devotional for Young Single Adults", "Face to face with Elder Quentin L. Cook for YSA", "August 18, 2023", "9 PM", addressR, "devotional@youngadult.com");
        Console.WriteLine();

        Console.WriteLine("Event Number: 2");
        Console.WriteLine();
        Console.WriteLine(reception.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(reception.GenerateDetailedReception());

        Console.WriteLine();
        Console.WriteLine(reception.GenerateShortReception());

        Address addressOG = new Address("Baba-Adisa", "Adewale", "Jakande", "Nigeria");

        OutdoorGathering outdoorGathering = new OutdoorGathering("Egungun Festival", "The Celebration of the Light", "January 16, 2024", "9 PM", addressOG, "sunny");
        Console.WriteLine();

        Console.WriteLine("Event Number: 3");

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateDetailedOutdoorGathering());

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateShortOutdoorGathering());
    }
}