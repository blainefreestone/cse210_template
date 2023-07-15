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

                while (true)
                {
                    Console.WriteLine("In what ways are you going to make this habit obvious? (Type 'done' when finished)");
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
                
                while (true)
                {
                    Console.WriteLine("In what ways are you going to make this habit attractive? (Type 'done' when finished)");
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

                while (true)
                {
                    Console.WriteLine("In what ways are you going to make this habit easy? (Type 'done' when finished)");
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

                while (true)
                {
                    Console.WriteLine("In what ways are you going to make this habit satisfying? (Type 'done' when finished)");
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

                while (true)
                {
                    Console.WriteLine("In what ways are you going to make this habit invisible? (Type 'done' when finished)");
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
                
                while (true)
                {
                    Console.WriteLine("In what ways are you going to make this habit unattractive? (Type 'done' when finished)");
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

                while (true)
                {
                    Console.WriteLine("In what ways are you going to make this habit difficult? (Type 'done' when finished)");
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

                while (true)
                {
                    Console.WriteLine("In what ways are you going to make this habit unsatisfying? (Type 'done' when finished)");
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

    }
    public void DisplayAll()
    {

    }
    public void GetCurrentDate()
    {

    }
}