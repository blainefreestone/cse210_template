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
    public string GetName()
    {
        return _name;
    }
    public bool IsDateCompleted(DateOnly date)
    {
        bool isDateCompleted = _datesCompleted.Contains(date);
        return isDateCompleted;
    }
    public List<DateOnly> GetDateCompletedList()
    {
        return _datesCompleted;
    }
    public DateOnly GetCurrentDate()
    {
        DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);
        return currentDate;
    }
    public void DisplayThisWeekHabitTracker()
    {
        string thisWeekHabitTrackerText = "";
        
        for (int i = 6; i>=0; i--)
        {
            if (IsDateCompleted(GetCurrentDate().AddDays(-i)) == true)
            {
                thisWeekHabitTrackerText += "[x] ";
            }
            else
            {
                thisWeekHabitTrackerText += "[ ] ";
            }
        }
        Console.WriteLine(thisWeekHabitTrackerText);
    }
    public abstract void Display();
    public abstract string GetRepresentationText();
    public abstract void Initialize();
}