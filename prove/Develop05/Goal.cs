public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _pointValue;
    public Goal(string name, string description, int pointValue)
    {
        _name = name;
        _description = description;
        _pointValue = pointValue;
    }
    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetRepresentationText();
    public string GetName() {return _name;}
    public virtual string GetDetailsText()
    {
        string detailsText = $"{_name} ({_description})";
        if (IsComplete()) {detailsText = "[X] " + detailsText;}
        else {detailsText = "[ ] " + detailsText;}
        
        return detailsText;
    }
}