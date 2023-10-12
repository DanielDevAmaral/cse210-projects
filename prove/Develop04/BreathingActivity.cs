class BreathingActivity : Activity
{
    private int _duration;

    public BreathingActivity() : base("Breathing Activity","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing", 0)
    {
        
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("How long, in seconds would you like for your session?");
        string secondsString = Console.ReadLine();
        _duration = int.Parse(secondsString);

        Console.Clear();
        Console.WriteLine("Get Ready!");
        ShowSpinner(2);

        Console.WriteLine($"Breathe in...");
        ShowCountDown(_duration/4);
        Console.WriteLine($"Now breathe out...");
        ShowCountDown(_duration/4);
         Console.WriteLine($"Breathe in...");
        ShowCountDown(_duration/4);
        Console.WriteLine($"Now breathe out...");
        ShowCountDown(_duration/4);

        DisplayEndMessage(_duration);
        

        
    }
    

}