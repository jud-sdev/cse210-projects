using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        string choice = Console.ReadLine();

        Entry anEntry = new Entry();
        Journal newJournal = new Journal();
        PromptGenerator newPromptGenerator = new PromptGenerator();

        while (choice != "5")
        {
            if (choice == "1")
            {
                string randomPrompt = newPromptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {randomPrompt}");
                Console.Write("> ");
                string response = Console.ReadLine();
                anEntry._entryText = response;
                anEntry._promptText = randomPrompt;
                anEntry._date = DateTime.Now.ToString("MM/dd/yyyy");
                newJournal.AddEntry(anEntry);  
            }
            else if (choice == "2")
            {
                newJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                newJournal.LoadFromFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                newJournal.SaveToFile(filename);
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

        }



    }
}