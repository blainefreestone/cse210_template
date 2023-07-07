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
    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }
    public override bool IsCompleted()
    {
        throw new NotImplementedException();
    }
    public override string GetRepresentationText()
    {
        throw new NotImplementedException();
    }
    public override string GetDetailsText()
    {
        return base.GetDetailsText();
    }
}