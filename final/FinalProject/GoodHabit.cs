public class GoodHabit : Habit
{
    private List<TwoMinuteRule> _twoMinuteRules = new List<TwoMinuteRule>();
    public GoodHabit(string name, Identity identity) : base(name, identity) {}
    public override void Display()
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

        displayText += "(4) MAKE IT SATISFYING:\n";
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

        Console.WriteLine(displayText);
        Console.WriteLine();

        Console.WriteLine("Habit tracker (Past 7 days):");
        DisplayThisWeekHabitTracker();

        Console.WriteLine();
        Console.WriteLine("To add a two minute rule, type 'newrule':");
        string userInput = Console.ReadLine();
        if (userInput.ToLower() == "newrule")
        {
            CreateTwoMinuteRule();
        }
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
        foreach (DateOnly date in _datesCompleted)
        {
            representationText += $"{date}\n";
        }

        representationText += "twominuterule\n";
        foreach (TwoMinuteRule twoMinuteRule in _twoMinuteRules)
        {
            representationText += $"{twoMinuteRule.GetRepresentationText()}\n";
        }

        return representationText;
    }
    public override void Initialize()
    {
        Console.WriteLine("In what ways are you going to make this habit obvious? (Type 'done' when finished)");
        while (true)
        {
            Console.Write(">");
            string makeItObvious = Console.ReadLine();

            if (makeItObvious.ToLower() == "done")
            {
                break;
            }
            else
            {
                _makeItObvious.Add(makeItObvious);
            }
        }
        
        Console.WriteLine("In what ways are you going to make this habit attractive? (Type 'done' when finished)");
        while (true)
        {
            Console.Write(">");
            string makeItAttractive = Console.ReadLine();

            if (makeItAttractive.ToLower() == "done")
            {
                break;
            }
            else
            {
                _makeItAttractive.Add(makeItAttractive);
            }
        }

        Console.WriteLine("In what ways are you going to make this habit easy? (Type 'done' when finished)");
        while (true)
        {
            Console.Write(">");
            string makeItEasy = Console.ReadLine();

            if (makeItEasy.ToLower() == "done")
            {
                break;
            }
            else
            {
                _makeItEasy.Add(makeItEasy);
            }
        }

        Console.WriteLine("In what ways are you going to make this habit satisfying? (Type 'done' when finished)");
        while (true)
        {
            Console.Write(">");
            string makeItSatisfying = Console.ReadLine();

            if (makeItSatisfying.ToLower() == "done")
            {
                break;
            }
            else
            {
                _makeItSatisfying.Add(makeItSatisfying);
            }
        }        
    }
    public void CreateTwoMinuteRule()
    {
        Console.WriteLine("Please describe this rule.");
        string ruleDescription = Console.ReadLine();

        Console.WriteLine("How many minutes extra does this add onto the habit?");
        int addedTimeInMinutes = int.Parse(Console.ReadLine());

        DateOnly date = DateOnly.FromDateTime(DateTime.Now);

        TwoMinuteRule twoMinuteRule = new TwoMinuteRule(date, ruleDescription, addedTimeInMinutes);
        _twoMinuteRules.Add(twoMinuteRule);

        Console.WriteLine("Two-minute rule added!");
        Thread.Sleep(2000);
    }
    public void AddTwoMinuteRule(TwoMinuteRule twoMinuteRule)
    {
        _twoMinuteRules.Add(twoMinuteRule);
    }
}