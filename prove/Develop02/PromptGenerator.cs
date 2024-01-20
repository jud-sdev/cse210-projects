public class PromptGenerator
{
    public List<string> _prompts;
    public string GetRandomPrompt()
    {
       _prompts = new List<string>
       {
           "Who was the most interesting person I interacted with today?",
           "What was the best part of my day?",
           "How did I see the hand of the Lord in my life today?",
           "What was the strongest emotion I felt today?",
           "If I had one thing I could do over today, what would it be?",
           "What was the most challenging part of my day?",
           "What was my greatest achivement for the day?",
           "How have I helped others in need today?"
       };
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}