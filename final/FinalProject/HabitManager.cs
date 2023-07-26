public class HabitManager
{
    private List<Habit> _habits = new List<Habit>();
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
            Console.WriteLine();
            Console.WriteLine($"Choose an option:\n   1) Create new habit.\n   2) Display All Habits\n   3) Display Single Habit\n   4) Display Habit Tracker\n   5) Record Habit Completion for Today ({GetCurrentDate()})\n   6) Save and Quit\n   7) Delete Program Data");
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
                Console.WriteLine();
                Console.WriteLine("Please choose habit you would like to display:");
                string userHabitChoiceInText = Console.ReadLine();
                int userHabitChoice = int.Parse(userHabitChoiceInText);
                Console.Clear();
                DisplayHabit(_habits[userHabitChoice - 1]);
                Console.ReadLine();
            }
            else if (userChoice == 4)
            {
                Console.Clear();
                Console.WriteLine("Habit Tracker (Past 7 Days):");
                Console.WriteLine();
                DisplayAllHabitTrackers();
                Console.ReadLine();
            }
            else if (userChoice == 5)
            {
                DisplayHabitList();
                Console.WriteLine();
                Console.WriteLine("Please choose habit you would like to mark completed today:");
                string userHabitChoiceInText = Console.ReadLine();
                int userHabitChoice = int.Parse(userHabitChoiceInText);
                _habits[userHabitChoice - 1].RecordCompleted(GetCurrentDate());
            }
            else if (userChoice == 6)
            {
                Console.Clear();
                Console.WriteLine("Saving...");
                Save();
                Thread.Sleep(5000);
                Console.Clear();
                break;
            }
            else if (userChoice == 7)
            {
                Restore();
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

            if (userChoice != 1 & userChoice != 2)
            {
                Console.WriteLine("That is not a valid option. Please try again");
                Thread.Sleep(3000);
                continue;
            }

            Console.WriteLine("What is the name of this habit?");
            string name = Console.ReadLine();

            Console.WriteLine("Briefly, how would you describe the identity behind this habit?");
            string identityDescription = Console.ReadLine();

            Console.WriteLine("How would you put that in one word?");
            string identityDescriptor = Console.ReadLine();

            Identity identity = new Identity(identityDescriptor, identityDescription);

            if (userChoice == 1)
            {
                GoodHabit goodHabit = new GoodHabit(name, identity);
                goodHabit.Initialize();
                _habits.Add(goodHabit);
                break;
            }

            else if (userChoice == 2)
            {
                BadHabit badHabit = new BadHabit(name, identity);
                badHabit.Initialize();
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
                        while (true)
                        {
                            if (lines[i+j+k] == "mia") {break;}
                            else
                            {
                                goodHabit.AddMakeItObvious(lines[i+j+k]);
                            }
                            k += 1;
                        }
                    }

                    else if (lines[i+j] == "mia")
                    {
                        while (true)
                        {
                            if (lines[i+j+k] == "mie") {break;}
                            else
                            {
                                goodHabit.AddMakeItAttractive(lines[i+j+k]);
                            }
                            k += 1;
                        }
                    }

                    else if (lines[i+j] == "mie")
                    {
                        while (true)
                        {
                            if (lines[i+j+k] == "mis") {break;}
                            else
                            {
                                goodHabit.AddMakeItEasy(lines[i+j+k]);
                            }
                            k += 1;
                        }
                    }

                    else if (lines[i+j] == "mis")
                    {
                        while (true)
                        {
                            if (lines[i+j+k] == "dates") {break;}
                            else
                            {
                                goodHabit.AddMakeItSatisfying(lines[i+j+k]);
                            }
                            k += 1;
                        }
                    }         

                    else if (lines[i+j] == "dates")
                    {
                        while (true)
                        {
                            if (lines[i+j+k] == "twominuterule") {break;}
                            else
                            {
                                goodHabit.RecordCompleted(DateOnly.Parse(lines[i+j+k]));
                            }
                            k += 1;
                        }
                    }   

                    else if (lines[i+j] == "twominuterule")
                    {
                        while (true)
                        {
                            if (lines[i+j+k] == "badhabitstart") {break;}
                            else if (lines[i+j+k] == "goodhabitstart") {break;}
                            else if (lines[i+j+k] == "savefiledone") {break;}
                            else
                            {
                                string[] twoMinuteRuleParts = lines[i+j+k].Split("|");
                                DateOnly date = DateOnly.Parse(twoMinuteRuleParts[2]);
                                string ruleDescription = twoMinuteRuleParts[1];
                                int addedTimeInMinutes = int.Parse(twoMinuteRuleParts[0]);
                                
                                TwoMinuteRule twoMinuteRule = new TwoMinuteRule(date, ruleDescription, addedTimeInMinutes);

                                goodHabit.AddTwoMinuteRule(twoMinuteRule);
                            }
                            k += 1;
                        }
                    }                               
                    
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
                    else if (lines[i+j] == "goodhabitstart") {break;}
                    else if (lines[i+j] == "savefiledone") {break;}

                    else if (lines[i+j] == "mio")
                    {
                        while (true)
                        {
                            if (lines[i+j+k] == "mia") {break;}
                            else
                            {
                                badHabit.AddMakeItObvious(lines[i+j+k]);
                            }
                            k += 1;
                        }
                    }

                    else if (lines[i+j] == "mia")
                    {
                        while (true)
                        {
                            if (lines[i+j+k] == "mie") {break;}
                            else
                            {
                                badHabit.AddMakeItAttractive(lines[i+j+k]);
                            }
                            k += 1;
                        }
                    }

                    else if (lines[i+j] == "mie")
                    {
                        while (true)
                        {
                            if (lines[i+j+k] == "mis") {break;}
                            else
                            {
                                badHabit.AddMakeItEasy(lines[i+j+k]);
                            }
                            k += 1;
                        }
                    }

                    else if (lines[i+j] == "mis")
                    {
                        while (true)
                        {
                            if (lines[i+j+k] == "dates") {break;}
                            else
                            {
                                badHabit.AddMakeItSatisfying(lines[i+j+k]);
                            }
                            k += 1;
                        }
                    }         

                    else if (lines[i+j] == "dates")
                    {
                        while (true)
                        {
                            if (lines[i+j+k] == "badhabitstart") {break;}
                            else if (lines[i+j+k] == "goodhabitstart") {break;}
                            else if (lines[i+j+k] == "savefiledone") {break;}
                            else
                            {
                                badHabit.RecordCompleted(DateOnly.Parse(lines[i+j+k]));
                            }
                            k += 1;
                        }
                    }                                 
                    
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
        Console.Clear();
        Console.WriteLine("This will delete all your habits and their information.");
        Thread.Sleep(5000);
        Console.WriteLine();
        Console.WriteLine("This action cannot be undone.");
        Thread.Sleep(5000);
        Console.WriteLine();
        Console.WriteLine("Are you sure you want to do this? (Y)es or (N)o");

        while (true)
        {
            string userChoice = Console.ReadLine();
            if (userChoice.ToLower() == "y") 
            {
                _habits.Clear();
                break;
            }
            else if (userChoice.ToLower() == "n") {break;}
            else
            {
                Console.WriteLine("Invalid option... Data will not be restored.");
                break;
            }
        }
        
        _habits.Clear();
    }
    public void DisplayHabitList()
    {
        Console.Clear();
        
        Console.WriteLine("List of Habits:");
        Console.WriteLine();
        
        int i = 1;
        foreach (Habit habit in _habits)
        {
            Console.WriteLine($"   {i}) {habit.GetName()}");
            
            i += 1;
        }
    }
    public void DisplayHabit(Habit habit)
    {
        habit.Display();
        Console.WriteLine();
        Console.WriteLine("Habit Tracker (Last 7 Days):");
        habit.DisplayThisWeekHabitTracker();
    }
    public void DisplayAll()
    {
        int runningCount = 1;
        foreach(GoodHabit habit in _habits.OfType<GoodHabit>())
        {
            Console.Clear();
            Console.WriteLine($"Page {runningCount}/{_habits.Count()}\nPress ENTER for next page, type 'newrule' to add new two-minute rule, or type 'done' to exit.\n");
            DisplayHabit(habit);
            runningCount += 1; 

            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "done") {break;}
            else if (userInput == "newrule")
            {
                Console.Clear();
                Console.WriteLine("Describe this rule.");
                string description = Console.ReadLine();
                Console.WriteLine("How much extra time does this add to completing your habit?");
                int addedTimeInMinutes = int.Parse(Console.ReadLine());
                TwoMinuteRule twoMinuteRule = new TwoMinuteRule(GetCurrentDate(), description, addedTimeInMinutes);
                habit.AddTwoMinuteRule(twoMinuteRule);
            }
        }
        foreach(BadHabit habit in _habits.OfType<BadHabit>())
        {
            Console.Clear();
            Console.WriteLine($"Page {runningCount}/{_habits.Count()}\nPress ENTER for next page or type 'done' to exit.\n");
            DisplayHabit(habit);
            runningCount += 1; 

            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "done") {break;}
        }
    }
    public DateOnly GetCurrentDate()
    {
        DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);
        return currentDate;
    }
    public void DisplayAllHabitTrackers()
    {

        foreach (Habit habit in _habits)
        {
            Console.Write(String.Format("{0,-30}", habit.GetName()));
            habit.DisplayThisWeekHabitTracker();
            Console.WriteLine();
        }
    }
}