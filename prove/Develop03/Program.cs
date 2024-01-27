using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";
        while (response.ToLower() == "yes")
        {
            Scripture scripture = new Scripture("1 Nephi ", 3, 17, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them. ");
            Console.Clear();
            scripture.Display(); 
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");

            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;

                if (!scripture.HideRandomWord())
                {
                    Console.WriteLine("\nCongratulations!!! You've memorized all of the words in this scripture.");
                    break;
                }

                Console.Clear();
                scripture.Display();
                Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            }
            Console.Write("\nWould you like to repeat the scripture mastery? (yes or no) ");
            response = Console.ReadLine();

        }
    }
}