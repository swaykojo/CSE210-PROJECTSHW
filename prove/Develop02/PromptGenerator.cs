
class PromptGenerator
{
    public List<string> prompts = new List<string>() {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What are the personality traits in your best friend that you wish you had?",
        "What is your greatest hope for the future?",


    };

    public PromptGenerator()
    {

    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];

    }
}