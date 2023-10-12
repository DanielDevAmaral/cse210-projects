class ListiningActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private int _duration;
    

    public ListiningActivity() : base("Listining Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0)
    {

    }

    public void Run()
    {

      DisplayStartingMessage();
      
      Console.WriteLine();
      Console.Write("How long, in seconds would you like for your session? ");
      string secondsString = Console.ReadLine();
      _duration = int.Parse(secondsString);
      
      Console.Clear();
      Console.WriteLine("Get Ready!");
      ShowSpinner(2);

      Console.WriteLine("List as many responses you can to the following prompt:");
      GetRandomPrompt();
      Console.Write("You may begin in: ");
      ShowCountDown(5);
      GetListFromUser();
      DisplayEndMessage(_duration);

    }

    public void GetRandomPrompt()
    {
      _prompts.Add("Who are people that you appreciate?");
      _prompts.Add("What are personal strengths of yours?");
      _prompts.Add("Who are people that you have helped this week?");
      _prompts.Add("When have you felt the Holy Ghost this month?");
      _prompts.Add("Who are some of your personal heroes?");


      var random = new Random();
      int index = random.Next(_prompts.Count);
      Console.WriteLine($"--- {_prompts[index]} ---");
    }
    public List<string> GetListFromUser()
    {
      DateTime startTime = DateTime.Now;
      DateTime futureTime = startTime.AddSeconds(_duration);
      DateTime currentTime = DateTime.Now;

      List<string> userInputList = new List<string>();

      while (currentTime < futureTime)
      {
        Console.WriteLine();
        Console.Write("> ");
       string userInput = Console.ReadLine();
       userInputList.Add(userInput);
       currentTime = DateTime.Now; 
      }
      Console.WriteLine($"You listed {userInputList.Count} items!");
      Thread.Sleep(1000);
      return userInputList;
    }


}