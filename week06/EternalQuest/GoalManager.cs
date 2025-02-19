public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void SetGoals(List<Goal> goals)
    {
        _goals = goals;
    }

    public void SetScore(int score)
    {
        _score = score;
    }

    public List<Goal> GetGoals()
    {
        return _goals;
    }

    public int GetScore()
    {
        return _score;
    }

    public void Start()
    {
        int choice;
        do
        {
            DisplayPlayerInfo();
            Console.WriteLine($"Menu Options:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit");
            Console.Write("Select a choice from the menu: ");


            string userInput = Console.ReadLine();
            if (!int.TryParse(userInput, out choice) || choice < 1 || choice > 6)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 6.");
                continue;
            }

            switch (choice)
            {
                case 1: CreateGoal(); break;
                case 2: ListGoalNames(); break;
                case 3: SaveGoals(); break;
                case 4: LoadGoals(); break;
                case 5: RecordEvent(); break;
            }

        } while (choice != 6);
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {GetScore()} points.\n");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        foreach (var goal in GetGoals())
        {
            Console.WriteLine(goal);
        }
    }

    public void ListGoalDetails()
    {
        if (GetGoals().Count == 0)
        {
            Console.WriteLine("No goals created yet.");
            return;
        }

        Console.WriteLine("\nGoal Details:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal");
        Console.Write("What type of goal would you like to create: ");

        int choice;
        string userInput = Console.ReadLine();
        if (!int.TryParse(userInput, out choice) || choice < 1 || choice > 3)
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
        }

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        int target = 0;
        int bonus = 0;
        if (choice == 3)
        {
            Console.Write("How many times does this goal needs to be accomplished for a bonus? ");
            target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            bonus = int.Parse(Console.ReadLine());
        }

        Goal newGoal = choice switch
        {
            1 => new SimpleGoal(name, description, points),
            2 => new EternalGoal(name, description, points),
            3 => new ChecklistGoal(name, description, points, target, bonus),
            _ => throw new ArgumentException("Invalid choice. Number must be between 1 and 3.")
        };

        _goals.Add(newGoal);
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to record.");
            return;
        }

        Console.WriteLine("\nWhich goal did you accomplish?");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

        Console.Write("Enter the number of the completed goal: ");
        if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > _goals.Count)
        {
            Console.WriteLine("Invalid selection.");
            return;
        }

        Goal selectedGoal = _goals[choice - 1]; // Get the chosen goal
        selectedGoal.RecordEvent(); // Call its `RecordEvent()` method

        // Update _score based on the goal's points
        _score += selectedGoal.GetPoints();

        Console.WriteLine($"Your new score is: {_score} points.\n");
    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {

    }
}