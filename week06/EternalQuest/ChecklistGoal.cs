public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }

    public void SetTarget(int target)
    {
        _target = target;
    }

    public void SetBonus(int bonus)
    {
        _bonus = bonus;
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public int GetTarget()
    {
        return _target;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public override void RecordEvent()
    {
        int totalPoints = GetPoints() + GetBonus();

        if (IsComplete())
        {
            Console.Write($"Congratulations! You have earned {GetPoints()} points!");
            Console.WriteLine($"You now have {totalPoints} points.");
            Console.Write($"\nYou have: {totalPoints} points.\n");
        }
    }

    public override bool IsComplete()
    {
        return GetAmountCompleted() == GetTarget();
    }

    public override string GetDetailsString()
    {
        string checkMark = IsComplete() ? "✔️" : " ";
        return $"[{checkMark}] {GetShortName()} ({GetDescription()}) -- Currently completed: {GetAmountCompleted()}/{GetTarget()}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:^{GetShortName()}^{GetDescription()}^{GetPoints()}^{GetBonus()}^{GetTarget()}^{GetAmountCompleted()}";
    }
}