public class GoodHabit : Habit
{
    private List<TwoMinuteRule> _twoMinuteRules = new List<TwoMinuteRule>();
    public GoodHabit(string name, Identity identity) : base(name, identity) {}
    public override string GetDisplayText()
    {
        string displayText = "";

        displayText += $"HABIT: {_name} (GOOD)\n";
        displayText += $"IDENTITY: {_identity.GetDisplayText()}\n\n";

        displayText += "(1) MAKE IT OBVIOUS:\n";
        foreach (string makeItObvious in _makeItObvious)
        {
            displayText += $"   -{makeItObvious}\n";
        }
        displayText += "\n";

        displayText += "(2) MAKE IT ATTRACTIVE:\n";
        foreach (string makeItAttractive in _makeItAttractive)
        {
            displayText += $"   -{makeItAttractive}\n";
        }
        displayText += "\n";

        displayText += "(3) MAKE IT EASY:\n";
        foreach (string makeItEasy in _makeItEasy)
        {
            displayText += $"   -{makeItEasy}\n";
        }
        displayText += "\n";

        displayText += "(1) MAKE IT SATISFYING:\n";
        foreach (string makeItSatisfying in _makeItSatisfying)
        {
            displayText += $"   -{makeItSatisfying}\n";
        }
        displayText += "\n";

        displayText += "TWO-MINUTE RULE\n";
        foreach (TwoMinuteRule twoMinuteRule in _twoMinuteRules)
        {
            displayText += $"   -{twoMinuteRule.GetDisplayText()}\n";
        }

        return displayText;
    }
    public override string GetRepresentationText()
    {
        string representationText = "goodhabitstart\n";

        representationText += $"{_name}|{_identity.GetRepresentationText()}\n";
        
        representationText += "mio\n";
        foreach (string makeItObvious in _makeItObvious)
        {
            representationText += $"{makeItObvious}\n";
        }

        representationText += "mia\n";
        foreach (string makeItAttractive in _makeItAttractive)
        {
            representationText += $"{makeItAttractive}\n";
        }

        representationText += "mie\n";
        foreach (string makeItEasy in _makeItEasy)
        {
            representationText += $"{makeItEasy}\n";
        }

        representationText += "mis\n";
        foreach (string makeItSatisfying in _makeItSatisfying)
        {
            representationText += $"{makeItSatisfying}\n";
        }

        representationText += "dates\n";
        foreach (DateTime date in _datesCompleted)
        {
            representationText += $"{date}\n";
        }

        representationText += "twominuterule\n";
        foreach (TwoMinuteRule twoMinuteRule in _twoMinuteRules)
        {
            representationText += $"{twoMinuteRule.GetRepresentationText()}";
        }

        return representationText;
    }
    public void AddTwoMinuteRule(TwoMinuteRule twoMinuteRule)
    {
        _twoMinuteRules.Add(twoMinuteRule);
    }
}