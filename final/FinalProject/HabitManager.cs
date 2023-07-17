public class HabitManager
{
    private List<Habit> _habits = new List<Habit>();
    private DailyHabitTracker _habitTracker = new DailyHabitTracker();
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

    }
    public void Load()
    {

    }
    public void Restore()
    {

    }
    public void DisplayHabitList()
    {

    }
    public void DisplayHabit(int habitIndex)
    {
        Console.WriteLine(_habits[habitIndex].GetDisplayText());
    }
    public void DisplayAll()
    {
        int runningCount = 1;
        foreach(Habit habit in _habits)
        {
            Console.Clear();
            Console.WriteLine($"Page {runningCount}/{_habits.Count()}\nPress ENTER for next page or type 'done' to exit.");
            Console.Write(habit.GetDisplayText());
            string userInput = Console.ReadLine();
            runningCount += 1;
            
            if (userInput.ToLower() == "done") {break;}
        }
    }
    public void GetCurrentDate()
    {

    }
}