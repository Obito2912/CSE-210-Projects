public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        string checkMark = "";
        if (IsComplete())
        {
            checkMark = "✔️";
        } 
        return $"[{checkMark}] {_shortName} {_description} {_points}";
    }

    public abstract string GetStringRepresentation();
}