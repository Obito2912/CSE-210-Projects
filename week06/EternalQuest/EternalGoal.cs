public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override void RecordEvent()
    {
        int totalPoints = GetPoints() + GetPoints();
        Console.WriteLine($"Congratulations! You have earned: {totalPoints}");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:^{GetShortName()}^{GetDescription()}^{GetPoints()}";
    }
}