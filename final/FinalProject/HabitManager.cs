public class HabitManager
{
    private List<Habit> _habits = new List<Habit>();
    private DailyHabitTracker _habitTracker = new DailyHabitTracker();
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Habit Binder 1.0\nLoading...");
        Load();
        Thread.Sleep(5000);
        
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to your habit binder!");
            Console.WriteLine("Choose an option:\n   1) Create new habit.\n   2) Display All Habits\n   3) Display Single Habit\n   4) Record Habit Completion for Today\n   5) Save and Quit");
            string userChoiceInText = Console.ReadLine();
            int userChoice = int.Parse(userChoiceInText);

            if (userChoice == 1)
            {
                Create();
            }
            else if (userChoice == 2)
            {
                DisplayAll();
            }
            else if (userChoice == 3)
            {
                DisplayHabitList();
                Console.WriteLine("Choose habit you would like to display:");
                string userHabitChoiceInText = Console.ReadLine();
                int userHabitChoice = int.Parse(userHabitChoiceInText);
                DisplayHabit(_habits[userHabitChoice - 1]);
            }
            else if (userChoice == 5)
            {
                Console.Clear();
                Console.WriteLine("Saving...");
                Save();
                Thread.Sleep(5000);
                break;
            }
        }
    }
    public void Create()
    {
        Console.Clear();
        while (true)
        {
            Console.WriteLine("Would you like to (1) start a good habit or (2) break a bad habit?");
            string userChoiceInText = Console.ReadLine();
            int userChoice = int.Parse(userChoiceInText);

            if (userChoice == 1)
            {
                Console.WriteLine("What is the name of this habit?");
                string name = Console.ReadLine();

                Console.WriteLine("Briefly, how would you describe the identity behind this habit?");
                string identityDescription = Console.ReadLine();

                Console.WriteLine("How would you put that in one word?");
                string identityDescriptor = Console.ReadLine();

                Identity identity = new Identity(identityDescriptor, identityDescription);

                GoodHabit goodHabit = new GoodHabit(name, identity);

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
                        goodHabit.AddMakeItObvious(makeItObvious);
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
                        goodHabit.AddMakeItAttractive(makeItAttractive);
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
                        goodHabit.AddMakeItEasy(makeItEasy);
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
                        goodHabit.AddMakeItSatisfying(makeItSatisfying);
                    }
                }

                _habits.Add(goodHabit);

                break;
            }
            else if (userChoice == 2)
            {
                Console.WriteLine("What is the name of this habit?");
                string name = Console.ReadLine();

                Console.WriteLine("Briefly, how would you describe the identity behind this habit?");
                string identityDescription = Console.ReadLine();

                Console.WriteLine("How would you put that in one word?");
                string identityDescriptor = Console.ReadLine();

                Identity identity = new Identity(identityDescriptor, identityDescription);

                BadHabit badHabit = new BadHabit(name, identity);

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
                        badHabit.AddMakeItObvious(makeItObvious);
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
                        badHabit.AddMakeItAttractive(makeItAttractive);
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
                        badHabit.AddMakeItEasy(makeItEasy);
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
                        badHabit.AddMakeItSatisfying(makeItSatisfying);
                    }
                }
                
                _habits.Add(badHabit);

                break;
            }
        }
    }
    public void Save()
    {
        string fileName = "saveFile.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Habit habit in _habits)
            {
                outputFile.Write(habit.GetRepresentationText());
            }
            outputFile.WriteLine("savefiledone");
        }
    }
    public void Load()
    {
        string filename = "saveFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        int i = 0;
        while (true)
        {
            if (lines[i] == "goodhabitstart")
            {
                string[] mainLineParts = lines[i+1].Split("|");
                string name = mainLineParts[0];
                string identityDescriptor = mainLineParts[1];
                string identityDescription = mainLineParts[2];

                Identity identity = new Identity(identityDescriptor, identityDescription);
                GoodHabit goodHabit = new GoodHabit(name, identity);

                int j = 1;
                while (true)
                {
                    int k = 1;
                    if (lines[i+j] == "goodhabitstart") {break;}
                    else if (lines[i+j] == "badhabitstart") {break;}
                    else if (lines[i+j] == "savefiledone") {break;}

                    else if (lines[i+j] == "mio")
                    {
                        if (lines[i+j+k] == "mia") {break;}
                        else
                        {
                            goodHabit.AddMakeItObvious(lines[i+j+k]);
                        }
                        k += 1;
                    }

                    else if (lines[i+j] == "mia")
                    {
                        if (lines[i+j+k] == "mie") {break;}
                        else
                        {
                            goodHabit.AddMakeItAttractive(lines[i+j+k]);
                        }
                        k += 1;
                    }

                    else if (lines[i+j] == "mie")
                    {
                        if (lines[i+j+k] == "mis") {break;}
                        else
                        {
                            goodHabit.AddMakeItEasy(lines[i+j+k]);
                        }
                        k += 1;
                    }

                    else if (lines[i+j] == "mis")
                    {
                        if (lines[i+j+k] == "dates") {break;}
                        else
                        {
                            goodHabit.AddMakeItSatisfying(lines[i+j+k]);
                        }
                        k += 1;
                    }         

                    else if (lines[i+j] == "dates")
                    {
                        if (lines[i+j+k] == "twominuterule") {break;}
                        else
                        {
                            goodHabit.RecordCompleted(DateTime.Parse(lines[i+j+k]));
                        }
                        k += 1;
                    }   

                    else if (lines[i+j] == "twominuterule")
                    {
                        if (lines[i+j+k] == "badhabitstart") {break;}
                        else if (lines[i+j+k] == "goodhabitstart") {break;}
                        else if (lines[i+j+k] == "savefiledone") {break;}
                        else
                        {
                            string[] twoMinuteRuleParts = lines[i+j+k].Split("|");
                            DateTime date = DateTime.Parse(twoMinuteRuleParts[2]);
                            string ruleDescription = twoMinuteRuleParts[1];
                            int addedTimeInMinutes = int.Parse(twoMinuteRuleParts[0]);
                            
                            TwoMinuteRule twoMinuteRule = new TwoMinuteRule(date, ruleDescription, addedTimeInMinutes);

                            goodHabit.AddTwoMinuteRule(twoMinuteRule);
                        }
                        k += 1;
                    }

                    else if (lines[i+j] == "goodhabitstart") {break;}
                    else if (lines[i+j] == "badhabitstart") {break;}                                 
                    
                    j += 1;
                }
                _habits.Add(goodHabit);
            }
            
            else if (lines[i] == "badhabitstart")
            {
                string[] mainLineParts = lines[i+1].Split("|");
                string name = mainLineParts[0];
                string identityDescriptor = mainLineParts[1];
                string identityDescription = mainLineParts[2];

                Identity identity = new Identity(identityDescriptor, identityDescription);
                BadHabit badHabit = new BadHabit(name, identity);

                int j = 1;
                while (true)
                {
                    int k = 1;
                    if (lines[i+j] == "badhabitstart") {break;}
                    else if (lines[i+j] == "badhabitstart") {break;}
                    else if (lines[i+j] == "savefiledone") {break;}

                    else if (lines[i+j] == "mio")
                    {
                        if (lines[i+j+k] == "mia") {break;}
                        else
                        {
                            badHabit.AddMakeItObvious(lines[i+j+k]);
                        }
                        k += 1;
                    }

                    else if (lines[i+j] == "mia")
                    {
                        if (lines[i+j+k] == "mie") {break;}
                        else
                        {
                            badHabit.AddMakeItAttractive(lines[i+j+k]);
                        }
                        k += 1;
                    }

                    else if (lines[i+j] == "mie")
                    {
                        if (lines[i+j+k] == "mis") {break;}
                        else
                        {
                            badHabit.AddMakeItEasy(lines[i+j+k]);
                        }
                        k += 1;
                    }

                    else if (lines[i+j] == "mis")
                    {
                        if (lines[i+j+k] == "dates") {break;}
                        else
                        {
                            badHabit.AddMakeItSatisfying(lines[i+j+k]);
                        }
                        k += 1;
                    }         

                    else if (lines[i+j] == "dates")
                    {
                        if (lines[i+j+k] == "badhabitstart") {break;}
			            else if (lines[i+j+k] == "goodhabitstart") {break;}
                        else if (lines[i+j+k] == "savefiledone") {break;}
                        else
                        {
                            badHabit.RecordCompleted(DateTime.Parse(lines[i+j+k]));
                        }
                        k += 1;
                    }   


                    else if (lines[i+j] == "badhabitstart") {break;}
                    else if (lines[i+j] == "badhabitstart") {break;}                                 
                    
                    j += 1;
                }
                _habits.Add(badHabit);
            }

            else if (lines[i] == "savefiledone") {break;}

            i += 1;
        }
    }
    public void Restore()
    {

    }
    public void DisplayHabitList()
    {

    }
    public void DisplayHabit(Habit habit)
    {
        Console.Clear();
        Console.WriteLine(habit.GetDisplayText());
        Console.ReadLine();
    }
    public void DisplayAll()
    {
        int runningCount = 1;
        foreach(Habit habit in _habits)
        {
            Console.Clear();
            Console.WriteLine($"Page {runningCount}/{_habits.Count()}\nPress ENTER for next page or type 'done' to exit.\n");
            Console.Write(habit.GetDisplayText());
            string userInput = Console.ReadLine();
            runningCount += 1;
            
            if (userInput.ToLower() == "done") {break;}
        }
    }
    public DateTime GetCurrentDate()
    {
        DateTime currentDateTime = DateTime.Today;
        return currentDateTime;
    }
}