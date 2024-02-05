using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "";
        int breathingLog = 0;
        int reflectingLog = 0;
        int listingLog = 0;

        void DisplayLog()
        {
            Console.WriteLine("Activity Log - Current Session");
            Console.WriteLine($"Breathing Activity: {breathingLog}");
            Console.WriteLine($"Reflecting Activity: {reflectingLog}");
            Console.WriteLine($"Listing Activity: {listingLog}");
            Console.WriteLine();
        }

        while (input != "4")
        {
            Console.Clear();
            DisplayLog();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            input = Console.ReadLine();
            

            if (input == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.RunActivity();
                breathingActivity.Run();
                breathingActivity.DisplayEndingMessage();

                breathingLog++;
            }
            else if (input == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.RunActivity();
                reflectingActivity.Run();
                reflectingActivity.DisplayEndingMessage();

                reflectingLog++;
            }
            else if (input == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.RunActivity();
                listingActivity.Run();
                listingActivity.DisplayEndingMessage();

                listingLog++;
            }
            else if (input == "4")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Please enter the number of the menu option. ");
            }

        }
        Environment.Exit(0);
    }
}