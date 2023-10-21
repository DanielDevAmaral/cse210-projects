using System.IO; 
class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private Stream filename;

    public GoalManager()
    {
        _score = 0;
    }

    public void start()
    {
    //This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.
    DisplayPlayerInfo();
    Console.WriteLine();
    Console.WriteLine($"Menu Options:");
    Console.WriteLine($"1. Create New Goal");
    Console.WriteLine($"2. List Goals");
    Console.WriteLine($"3. Save Goals");
    Console.WriteLine($"4. Load Goals");
    Console.WriteLine($"5. Record Events");
    Console.WriteLine($"6. Quit");
    Console.WriteLine("Select a Choice from the Menu: ");
    int choice = int.Parse(Console.ReadLine());
    switch(choice)
    {
           case 1:
                CreateGoal();
                break;
            case 2:
                ListGoalNames();
                break;
            case 3:
                SaveGoals();
                break;
            case 4:
                LoadGoals();
                break;
            case 5:
                RecordEvent();
                break;
            case 6:
                Console.WriteLine("Goodbye!");
                return; // Sair do loop e encerrar o programa
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
            

    }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"you have: {_score} points");
    }
    public void ListGoalNames()
    {
    //Lists the names of each of the goals.
        for (int i = 0; i < _goals.Count; i++)
        {
            string checkbox = (_goals[i] is EternalGoal) ? "[ ]" : _goals[i].IsComplete() ? "[X]" : "[ ]";
            Console.WriteLine($"{i+1}. {checkbox} {_goals[i].ShortName()} ({_goals[i].Description()}) {_goals[i].GetDetailsString()}");
        }
        start();
    }
    public void ListGoalDetails()
    {
    //Lists the details of each goal (including the checkbox of whether it is complete).
    foreach (var goal in _goals)
    {
        Console.WriteLine($"({goal.Description()})");
    }
    }
public void CreateGoal()
{
    Console.WriteLine("The types of the Goals are: \n");
    Console.WriteLine("1. Simple Goal");
    Console.WriteLine("2. Eternal Goal");
    Console.WriteLine("3. CheckList Goal");

    int goalType = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Create a New Goal:");
    Console.Write("Enter the goal name: ");
    string name = Console.ReadLine();

    Console.Write("Enter the goal description: ");
    string description = Console.ReadLine();

    Console.Write("Enter the point value for this goal: ");
    string points = Console.ReadLine();

    Goal newGoal = null;

    switch (goalType)
    {
        case 1:
            newGoal = new SimpleGoal(name, description, points);
            break;
        case 2:
            newGoal = new EternalGoal(name, description, points);
            break;
        case 3:
            Console.Write("Enter the target count for the checklist goal: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Enter the bonus points for completing the checklist goal: ");
            int bonus = int.Parse(Console.ReadLine());
            newGoal = new ChecklistGoal(name, description, points, target, bonus);
            break;
        default:
            Console.WriteLine("Invalid goal type.");
            return; // Return without adding the goal
    }

    _goals.Add(newGoal); // Add the new goal to the list of goals
    Console.WriteLine("New goal created and added to the list.");
    start();
}
    public void RecordEvent()
    {
    //Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.

 for (int i = 0; i < _goals.Count; i++)
        {
            string checkbox = (_goals[i] is EternalGoal) ? "[ ]" : _goals[i].IsComplete() ? "[X]" : "[ ]";
            Console.WriteLine($"{i+1}. {checkbox} {_goals[i].ShortName()} ({_goals[i].Description()}) {_goals[i].GetDetailsString()}");
        }

    Console.Write("Which goal did you accomplish? ");

    int goalIndex = int.Parse(Console.ReadLine()) -1;

    if (goalIndex >= 0 && goalIndex < _goals.Count)
    {
        Goal selectedGoal = _goals[goalIndex];

        if(selectedGoal is ChecklistGoal checklistGoal)
        {
            checklistGoal.RecordEvent();

            if(checklistGoal.IsComplete())
            {
                string representation = checklistGoal.GetStringRepresentation();
                string[] parts = representation.Split(",");

                _score += int.Parse(parts[3]) + int.Parse(parts[5]);
                Console.WriteLine($"Congratulations! You earned {int.Parse(parts[3])} points.");
            }
            else
            {
                string representation = checklistGoal.GetStringRepresentation();
                string[] parts = representation.Split(",");

                _score += int.Parse(parts[3]);
                Console.WriteLine($"Congratulations! You earned {int.Parse(parts[3])} points.");
            }
        }
        else if (selectedGoal is EternalGoal eternalGoal)
        {
            eternalGoal.RecordEvent();

            if(eternalGoal.IsComplete())
            {
                string representation = eternalGoal.GetStringRepresentation();
                string[] parts = representation.Split(",");

                _score += int.Parse(parts[3]);
                Console.WriteLine($"Congratulations! You earned {int.Parse(parts[3])} points.");
            }
        }
        else if (selectedGoal is SimpleGoal simpleGoal)
        {
            simpleGoal.RecordEvent();
            if(selectedGoal.IsComplete())
            {
            string representation = simpleGoal.GetStringRepresentation();
            string[] parts = representation.Split(",");

            _score += int.Parse(parts[3]);
            Console.WriteLine($"Congratulations! You earned {int.Parse(parts[3])} points.");
            }
        }
        start();
    }
    
    }
    public void SaveGoals()
    {
        Console.Write("Choose a name for the file: ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);

            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        start();

    }
    public void LoadGoals()
    {
         Console.Write("Put the name of the file: ");
         string fileName = Console.ReadLine();
         string[] lines = System.IO.File.ReadAllLines(fileName);

         int.TryParse(lines[0], out int score);
         {
            _score = score;
         }

         for (int i = 1; i < lines.Length; i++)
         {
            string line = lines[1];
            string[] parts = line.Split(",");

            string goalType = parts[0];
            string goalName = parts[1];
            string goalDesc = parts[2];
            string goalPoints = parts[3];

            Goal newGoal = null;
            if (goalType == "Simple Goal")
            {
                bool isComplete = bool.Parse(parts[4]);
                newGoal = new SimpleGoal(goalName, goalDesc, goalPoints);
            }
            else if (goalType == "Eternal Goal")
            {
                newGoal = new EternalGoal(goalName, goalDesc, goalPoints);
            }
            else if (goalType == "Checklist Goal")
            {
                int target = int.Parse(parts[4]);
                int bonus = int.Parse(parts[5]);
                newGoal = new ChecklistGoal(goalName, goalDesc, goalPoints, target, bonus);
            }

            if(newGoal != null)
            {
                _goals.Add(newGoal);
            }


         }
    }

}