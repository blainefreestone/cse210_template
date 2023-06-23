using System;
class Program
{
    static void Main(string[] args)
    {
        Reference demoReference = new Reference("3 Nephi", 18, 12, 13);
        Scripture demoScripture = new Scripture(demoReference, "And I give unto you a commandment that ye shall do these things. And if ye shall always do these things blessed are ye, for ye are built upon my rock. But whoso among you shall do more or less than these are not built upon my rock, but are built upon a sandy foundation; and when the rain descends, and the floods come, and the winds blow, and beat upon them, they shall fall, and the gates of hell are ready open to receive them.");

        

        // Main program loop.
        for (;;)
        {
            // Print scripture (not, partly or fully filled) and console instructions.
            Console.Clear();
            if (demoScripture.IsCompletelyHidden() == true) {break;}

            Console.WriteLine(demoScripture.GetDisplayText());
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue or type quit to finish:");
            string userInput = Console.ReadLine();

            if (userInput == "quit") { break; }
            else
            {
                // Randomly hide words and clear console.
                demoScripture.RandomlyHideWords();
            }
        }
        Console.Write("Done");
        }
}