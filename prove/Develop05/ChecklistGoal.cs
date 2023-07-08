public class ChecklistGoal : Goal
{
    private int _bonusValue;
    private int _target;
    private int _numberCompleted;
    public ChecklistGoal(string name, string description, int pointValue, int bonusValue, int target) : base(name, description, pointValue)
    {
        _bonusValue = bonusValue;
        _target = target;
        _numberCompleted = 0;
    }
    public override int RecordEvent()
    {
        _numberCompleted += 1;
        if (_numberCompleted == _target)
        {
            Console.WriteLine($"Congratulations! You have earned {_pointValue} points!");
            return _pointValue;
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {_pointValue + _bonusValue} points!");
            return _pointValue + _bonusValue;
        }
    }
    public override bool IsComplete()
    {
        if (_numberCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string GetRepresentationText()
    {
        string representationText = $"Checklist|{_name}|{_description}|{_pointValue}|{_bonusValue}|{_target}|{_numberCompleted}";
        return representationText;
    }
    public override string GetDetailsText()
    {
        string detailsText = $"{_name} ({_description}) -- Currently completed: {_numberCompleted}/{_target}";
        if (IsComplete()) {detailsText = "[X] " + detailsText;}
        else {detailsText = "[ ] " + detailsText;}
        
        return detailsText;
    }
}