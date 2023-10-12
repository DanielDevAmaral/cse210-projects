class ReflectingActivity : Activity
{
      
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    private int _duration = 30;

    public ReflectingActivity() : base("Reflecting Activity", "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0)
    {
      _prompts.Add("Think of a time when you stood up for someone else.");
      _prompts.Add("Think of a time when you did something really difficult.");
      _prompts.Add("Think of a time when you helped someone in need.");
      _prompts.Add("Think of a time when you did something truly selfless.");

      _questions.Add("Why was this experience meaningful to you?");
      _questions.Add("Have you ever done anything like this before?");
      _questions.Add("How did you get started?");
      _questions.Add("How did you feel when it was complete?");
      _questions.Add("What made this time different than other times when you were not as successful?");
      _questions.Add("What is your favorite thing about this experience?");
      _questions.Add("What could you learn from this experience that applies to other situations?");
      _questions.Add("What did you learn about yourself through this experience?");
      _questions.Add("How can you keep this experience in mind in the future?");
      
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
    
      Console.WriteLine("Consider the following prompt: ");
      DisplayPrompt();
      Console.WriteLine("When you have something in mind, press enter to continue");

      while (true)
      {
        if(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
        {
          break;
        }
      }

      Console.WriteLine("Now ponder on the each of the following questions as they relate to this experience.");
      Console.Write("You may begin in: ");
      ShowCountDown(5);
      DisplayQuestions();
      DisplayEndMessage(_duration);
    }
   public string GetRandomPrompt()
   { 
      var random = new Random();



      int index = random.Next(_prompts.Count);
      return _prompts[index];
   }
    public string GetRandomQuestion()
    { 
      var random = new Random();
      int index = random.Next(_questions.Count);
      return _questions[index];
    }
    public void DisplayPrompt()
    { 
      string randomPrompt = GetRandomPrompt();
      Console.WriteLine($"--- {randomPrompt} ---");
      
     }
    public void DisplayQuestions()
    {

      DateTime startTime = DateTime.Now;
      DateTime futureTime = startTime.AddSeconds(_duration);
      DateTime currentTime = DateTime.Now;

      Console.Clear();

      while (currentTime < futureTime)
      {
              string randomQuestion = GetRandomQuestion();
              Console.WriteLine($"{randomQuestion}");
              ShowSpinner(_duration/2);
              Thread.Sleep(1000);
              currentTime = DateTime.Now; 
        }
        
      }
    }
    
