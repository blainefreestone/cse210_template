public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int pointValue) : base(name, description, pointValue) {}
    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_pointValue} paints!");

        return _pointValue;
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetRepresentationText()
    {
        string representationText = $"Eternal|{_name}|{_description}|{_pointValue}";
        return representationText;
    }
}