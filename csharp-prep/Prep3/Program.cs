using System;

class Program
{
    static void Main(string[] args)
    {
        string replayGame = "yes";
        while (replayGame.ToLower() == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            int userGuess = int.Parse(guess);

            int count = 0;

            while (magicNumber != userGuess)
            {
                if (userGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (userGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }

                count += 1;

                Console.Write("What is your guess? ");
                guess = Console.ReadLine();
                userGuess = int.Parse(guess);

                
            }
            int last_count = count + 1;
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"It took you {last_count} attempts to guess the right number.");
            Console.Write("Do you want to play again [yes/no]? ");
            replayGame = Console.ReadLine();
        }
        Console.WriteLine("Thanks for playing the game, hope you had fun!");


    }
}