public class BadHabit : Habit
{
    public BadHabit(string name, Identity identity) : base(name, identity) {}
    public override string GetDisplayText()
    {
        string displayText = "";

        displayText += $"HABIT: {_name} (BAD)\n";
        displayText += $"IDENTITY: {_identity.GetDisplayText()}\n\n";

        displayText += "(1) MAKE IT INVISIBLE:\n";
        foreach (string makeItObvious in _makeItObvious)
        {
            displayText += $"   -{makeItObvious}\n";
        }
        displayText += "\n";

        displayText += "(2) MAKE IT UNATTRACTIVE:\n";
        foreach (string makeItAttractive in _makeItAttractive)
        {
            displayText += $"   -{makeItAttractive}\n";
        }
        displayText += "\n";

        displayText += "(3) MAKE IT DIFFICULT:\n";
        foreach (string makeItEasy in _makeItEasy)
        {
            displayText += $"   -{makeItEasy}\n";
        }
        displayText += "\n";

        displayText += "(4) MAKE IT UNSATISFYING:\n";
        foreach (string makeItSatisfying in _makeItSatisfying)
        {
            displayText += $"   -{makeItSatisfying}\n";
        }
        displayText += "\n";

        return displayText;
    }
    public override string GetRepresentationText()
    {
        string representationText = "badhabitstart\n";

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
        foreach (DateOnly date in _datesCompleted)
        {
            representationText += $"{date}\n";
        }

        return representationText;
    }
}