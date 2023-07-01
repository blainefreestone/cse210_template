using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        ListingActivity listingActivity = new ListingActivity();
        
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listening activity");
            Console.WriteLine("  4. Activity Statistics");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");
            string userChoiceInText = Console.ReadLine();
            int userChoice = int.Parse(userChoiceInText);
            if (userChoice == 1) {breathingActivity.Run();}
            else if (userChoice == 2) {reflectingActivity.Run();}
            else if (userChoice == 3) {listingActivity.Run();}
            else if (userChoice == 4)
            {
                int totalTimeInSeconds = breathingActivity.GetTimeInSeconds() + reflectingActivity.GetTimeInSeconds() + listingActivity.GetTimeInSeconds();
                int totalCount = breathingActivity.GetCount() + reflectingActivity.GetCount() + listingActivity.GetCount();
                string totalTimeInMinutesInText = (string.Format("{0:F1}",totalTimeInSeconds / 60)).ToString();
                Console.WriteLine($"In this session you completed a total of {totalCount} activities and spent a total of {totalTimeInMinutesInText} minutes in activities.");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
            }
            else if (userChoice == 5) {break;}
        }
    }
}