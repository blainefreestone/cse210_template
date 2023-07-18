public class TwoMinuteRule
{
    private DateTime _date;
    private string _ruleDescription;
    private int _addedTimeInMinutes;
    public TwoMinuteRule(DateTime date, string ruleDescription, int addedTimeInMinutes)
    {
        _date = date;
        _ruleDescription = ruleDescription;
        _addedTimeInMinutes = addedTimeInMinutes;
    }
    public string GetRepresentationText()
    {
        return $"{_addedTimeInMinutes}|{_ruleDescription}|{_date}";
    }
    public string GetDisplayText()
    {
        return $"{_addedTimeInMinutes} minutes: {_ruleDescription} ({_date})";
    }
}