public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, string description, int pointValue) : base(name, description, pointValue)
    {
        _isComplete = false;
    }
    public override int RecordEvent()
    {
        _isComplete = true;
        
        Console.WriteLine($"Congratulations! You have earned {_pointValue} points!");

        return _pointValue;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetRepresentationText()
    {
        string representationText = $"Simple|{_name}|{_description}|{_pointValue}|{_isComplete}";
        return representationText;
    }
}