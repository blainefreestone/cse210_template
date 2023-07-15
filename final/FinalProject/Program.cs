using System;

class Program
{
    static void Main(string[] args)
    {
        HabitManager habitManager = new HabitManager();
        habitManager.Create();
        habitManager.DisplayAll();
    }
}