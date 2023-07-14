public class TwoMinuteRule
{
    private DateOnly _date;
    private string _ruleDescription;
    private int _addedTimeInMinutes;
    public TwoMinuteRule(DateOnly date, string ruleDescription, int addedTimeInMinutes)
    {
        _date = date;
        _ruleDescription = ruleDescription;
        _addedTimeInMinutes = addedTimeInMinutes;
    }
    public string GetDisplayText()
    {
        return $"{_addedTimeInMinutes} minutes: {_ruleDescription} ({_date})";
    }
}