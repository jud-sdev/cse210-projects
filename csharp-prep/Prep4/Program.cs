using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> listNumbers = new List<int>();
        int userNumber = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                listNumbers.Add(userNumber);
            }
        }

        int sum = 0;
        int largest = -1;
        int smallestPositive = 999999999;

        foreach (int number in listNumbers)
        {
            sum += number;
            if (number > largest)
            {
                largest = number;
            }
            if (number > 0)
            {
                if (number < smallestPositive)
                {
                    smallestPositive = number;
                }
            }
        }
        
        float average = ((float)sum) / listNumbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        Console.WriteLine("The sorted list is: ");
        listNumbers.Sort();
        foreach (int sortedNumber in listNumbers)
        {
            Console.WriteLine(sortedNumber);
        }

    }
}