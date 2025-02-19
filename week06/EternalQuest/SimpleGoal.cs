public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        int totalPoints = GetPoints() + GetPoints();
        if (IsComplete())
        {
            Console.Write($"Congratulations! You have earned {GetPoints()} points!");
            Console.WriteLine($"You now have {totalPoints} points.");
            Console.Write($"\nYou have: {totalPoints} points");
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:^{GetShortName()}^{GetDescription()}^{GetPoints()}^{IsComplete()}";
    }
}