public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int pointValue) : base(name, description, pointValue) {}
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