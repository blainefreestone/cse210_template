public class BadHabit : Habit
{
    public BadHabit(string name, Identity identity) : base(name, identity) {}
    public override void Display()
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

        Console.WriteLine(displayText);
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
    public override void Initialize()
    {
        Console.WriteLine("In what ways are you going to make this habit invisible? (Type 'done' when finished)");
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
        
        Console.WriteLine("In what ways are you going to make this habit unattractive? (Type 'done' when finished)");
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

        Console.WriteLine("In what ways are you going to make this habit difficult? (Type 'done' when finished)");
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

        Console.WriteLine("In what ways are you going to make this habit unsatisfying? (Type 'done' when finished)");
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
}