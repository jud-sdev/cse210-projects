using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activityList = new List<Activity>();
        
        Running running = new Running("July 15, 2023", 30, 4.8);
        activityList.Add(running);

        StationaryBicycles stationaryBicycles = new StationaryBicycles("July 17, 2023", 60, 15);
        activityList.Add(stationaryBicycles);

        Swimming swimming = new Swimming("July 24, 2023", 20, 20);
        activityList.Add(swimming);

        Console.WriteLine("Activity:");
        Console.WriteLine();

        foreach (Activity activity in activityList) 
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}