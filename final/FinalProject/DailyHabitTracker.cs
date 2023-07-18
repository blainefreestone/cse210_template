public class DailyHabitTracker
{
    private List<Habit> _habits = new List<Habit>();
    public void DisplayAllHabitTrackers()
    {

        foreach (Habit habit in _habits)
        {
            Console.Write(String.Format("{0,-30}", habit.GetName()));
            DisplayThisWeekHabitTracker(habit);
            Console.WriteLine();
        }
    }
    public void DisplayThisWeekHabitTracker(Habit habit)
    {
        string thisWeekHabitTrackerText = "";
        
        for (int i = 6; i>=0; i--)
        {
            if (habit.IsDateCompleted(GetCurrentDate().AddDays(-i)) == true)
            {
                thisWeekHabitTrackerText += "[x] ";
            }
            else
            {
                thisWeekHabitTrackerText += "[ ] ";
            }
        }
        Console.Write(thisWeekHabitTrackerText);
    }
    public void AddHabit(Habit habit)
    {
        _habits.Add(habit);
    }
    public DateOnly GetCurrentDate()
    {
        DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);
        return currentDate;
    }
}