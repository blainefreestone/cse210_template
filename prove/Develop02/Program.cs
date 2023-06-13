using System;
using System.IO;

class Program
{

    public class Entry
    {
        public string _date;
        public string _prompt;
        public string _userEntry;
        public void DisplayEntry()
        {
            Console.WriteLine($"Date: {_date} - Prompt: {_prompt}\n{_userEntry}");
        }
        public string CompileEntry()
        {
            string entry = $"{_date}| {_prompt}| {_userEntry}";
            return entry;
        }
    }

    public class Journal
    {
        public List<Entry> _listOfEntries = new List<Entry>();

        public void DisplayJournal()
        {
            Console.WriteLine("");
            foreach (Entry entry in _listOfEntries)
            {
                entry.DisplayEntry();
                Console.WriteLine("");
            }
        }
        public void SaveJournal(string fileName)
        {
            using (StreamWriter outputFile = new StreamWriter(fileName))
            foreach (Entry entry in _listOfEntries)
            {
                {
                    outputFile.WriteLine(entry.CompileEntry());
                }
            }
        }
    }

    static void Main(string[] args)
    {
        Journal currentJournal = new Journal();
        
        // Main program loop.
        while (true)
        {

            // List of prompts.
            List<string> prompts = new List<string>
            {
                "What was the best thing that happened today?",
                "What was the worst thing that happened today?",
                "What am I grateful for today?",
                "What did I do today that I am proud of?",
                "What is a current problem or challenge I am facing?"
            };

            // Opening menu.
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Create Prompt\n6. Quit");
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();

            if (choice == "1") // Write Journal Entry
            {

                Entry currentEntry = new Entry();
                // Generate random prompt from list.
                Random rnd = new Random();
                int randIndex = rnd.Next(prompts.Count);
                currentEntry._prompt = prompts[randIndex];
                
                // Take input from user and create object.
                Console.WriteLine($"{currentEntry._prompt}");
                Console.Write($"> ");
                currentEntry._userEntry = Console.ReadLine();
                DateTime theCurrentTime = DateTime.Now;
                currentEntry._date = theCurrentTime.ToShortDateString();

                currentJournal._listOfEntries.Add(currentEntry);

            }

            else if (choice == "2") // Display Journal
            {
                currentJournal.DisplayJournal();
            }

            else if (choice == "3") // Load Journal
            {
                currentJournal = new Journal();
                
                Console.WriteLine("What is the filename?");
                string loadFileName = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(loadFileName);

                foreach (string line in lines)
                    {
                        Entry loadEntry = new Entry();
                        string[] parts = line.Split("|");

                        loadEntry._date = parts[0];
                        loadEntry._prompt = parts[1];
                        loadEntry._userEntry = parts[2];

                        currentJournal._listOfEntries.Add(loadEntry);
                    }

            }

            else if (choice == "4") // Save Journal
            {
                Console.WriteLine("What is the filename?");
                string saveFileName = Console.ReadLine();
                currentJournal.SaveJournal(saveFileName);
            }

            else if (choice == "5") // Create Prompt
            {
                    Console.WriteLine("What would you like your prompt to say?");
                    string userPrompt = Console.ReadLine();
                    prompts.Add(userPrompt);
                    Console.WriteLine("Prompt succesfully added!");
            }

            else if (choice == "6") // Quit Program
            {
                break;
            }
            
            else
            {
                Console.WriteLine("Invalid Choice.");
            }
        }
    }
}