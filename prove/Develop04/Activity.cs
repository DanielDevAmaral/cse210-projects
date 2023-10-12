class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
      Console.Clear();
      Console.WriteLine($"Welcome to the {_name}.");
      Console.WriteLine();
      Console.WriteLine($"This activity will help you {_description}");
      
    }

    public void DisplayEndMessage(int duration)
    {
        Console.WriteLine($"Well done!");
        Console.WriteLine($"You have completed {duration} seconds of {_name}");
        ShowSpinner(6);
    }
    public void ShowSpinner (int time)
    {

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(time);
        DateTime currentTime = DateTime.Now;
        
        List<string> loadingAnimation = new List<string>();
        loadingAnimation.Add("|");
        loadingAnimation.Add("/");
        loadingAnimation.Add("-");
        loadingAnimation.Add("\\");
        loadingAnimation.Add("|");
        loadingAnimation.Add("/");
        loadingAnimation.Add("-");
        loadingAnimation.Add("\\");
        
        while (currentTime < futureTime)
        {
            foreach(string s in loadingAnimation)
            {
            Console.Write(s);
            Thread.Sleep(300);
            Console.Write("\b \b");
            currentTime = DateTime.Now; 
            }
            currentTime = DateTime.Now; 
        }

    }
        public void ShowCountDown (int seconds)
    {
            for(int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

}