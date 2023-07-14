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