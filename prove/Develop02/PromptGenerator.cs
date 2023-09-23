
public class PromptGenerator
{
    public List<string> _prompts = new();

    public Random _random = new Random(); // Create a single Random object to reuse.

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        string randomPrompt = _prompts[index];
        return randomPrompt;
    }
}






