public abstract class Habit
{
    protected string _name;
    protected Identity _identity;
    protected List<string> _makeItObvious = new List<string>();
    protected List<string> _makeItAttractive = new List<string>();
    protected List<string> _makeItEasy = new List<string>();
    protected List<string> _makeItSatisfying = new List<string>();
    protected List<DateOnly> _datesCompleted = new List<DateOnly>();
    public Habit(string name, Identity identity)
    {
        _name = name;
        _identity = identity;
    }
    public void AddMakeItObvious(string plan)
    {
        _makeItObvious.Add(plan);
    }
    public void AddMakeItAttractive(string plan)
    {
        _makeItAttractive.Add(plan);
    }
    public void AddMakeItEasy(string plan)
    {
        _makeItEasy.Add(plan);
    }
    public void AddMakeItSatisfying(string plan)
    {
        _makeItSatisfying.Add(plan);
    }
    public void RecordCompleted(DateOnly dateCompleted)
    {
        _datesCompleted.Add(dateCompleted);
    }
    public abstract string GetDisplayText();
    public abstract string GetRepresentationText();
}