using System;
class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();

        Reference demoReference = new Reference("3 Nephi", 18, 12, 13);
        Scripture demoScripture = new Scripture(demoReference, "And I give unto you a commandment that ye shall do these things. And if ye shall always do these things blessed are ye, for ye are built upon my rock. But whoso among you shall do more or less than these are not built upon my rock, but are built upon a sandy foundation; and when the rain descends, and the floods come, and the winds blow, and beat upon them, they shall fall, and the gates of hell are ready open to receive them.");
        scriptures.Add(demoScripture);

        Reference demoReference2 = new Reference("John", 3 ,16);
        Scripture demoScripture2 = new Scripture(demoReference2, "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        scriptures.Add(demoScripture2);

        Reference demoReference3 = new Reference("1 Nephi", 2, 15);
        Scripture demoScripture3 = new Scripture(demoReference3, "And my father dwelt in a tent.");
        scriptures.Add(demoScripture3);

        // Choose random scripture.
        Random rnd = new Random();
        int r = rnd.Next(scriptures.Count);
        Scripture scripture = scriptures[r];

        // Main program loop.
        for (;;)
        {
            // Print scripture (not, partly or fully filled) and console instructions.
            Console.Clear();
            if (scripture.IsCompletelyHidden() == true) {break;}

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue or type quit to finish:");
            string userInput = Console.ReadLine();

            if (userInput == "quit") { break; }
            else
            {
                // Randomly hide words and clear console.
                scripture.RandomlyHideWords();
            }
        }
        Console.Write("Done");
        }
}