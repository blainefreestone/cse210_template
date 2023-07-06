public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, string description, int pointValue) : base(name, description, pointValue)
    {
        _isComplete = false;
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
}