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
                return;
            }

            switch (choice)
            {
                case 1: CreateGoal(); break;
                case 2: ListGoalDetails(); break;
                case 3: SaveGoals(); break;
                case 4: LoadGoals(); break;
                case 5: RecordEvent(); break;
            }

        } while (choice != 6);
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {GetScore()} points.\n");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        int numeration = 0;
        foreach (var goal in _goals)
        {
            numeration++;
            Console.WriteLine($"{numeration}. {goal.GetShortName()}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        int numeration = 0;
        foreach (Goal goal in _goals)
        {
            numeration++;
            Console.WriteLine($"{numeration}. {goal.GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal");
        Console.Write("What type of goal would you like to create? ");

        int choice;
        string userInput = Console.ReadLine();
        if (!int.TryParse(userInput, out choice) || choice < 1 || choice > 3)
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
            return;
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
        ListGoalNames();
        Console.Write("\nWhich goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());

        Goal selectedGoal = _goals[choice - 1];
        selectedGoal.RecordEvent();

        if (selectedGoal is not EternalGoal)
        {
            _score += selectedGoal.GetPoints();
        }
        Console.WriteLine($"Congratulations! You have earned {_score} points!");
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        try
        {
            using StreamWriter writer = new StreamWriter(filename);
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goal(s): {ex.Message}");
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();


        string[] lines = File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);
        _goals.Clear();
        Goal goal;

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("^");

            if (parts[0] == "SimpleGoal")
            {
                goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
            }
            else if (parts[0] == "EternalGoal")
            {
                goal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
            }
            else if (parts[0] == "ChecklistGoal")
            {
                goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
            }
            else
            {
                Console.WriteLine($"Error: Failed to load goal from line: {lines[i]}");
                continue;
            }
            _goals.Add(goal);
        }
    }
}