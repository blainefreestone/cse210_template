public class ListingActivity : Activity
{
    public ListingActivity() : base()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts.Add("What are some things you are especially grateful for today?");
        _prompts.Add("How have you seen the hand of the Lord in your life this week?");
        _prompts.Add("Who has brightened your day recently?");
        _prompts.Add("What is something new you learned in the past month?");
    }
    private int _count;
    private List<string> _prompts = new List<string>();
    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int r = rnd.Next(_prompts.Count);
        return _prompts[r];
    }
    public List<string> GetListFromUser(int durationSeconds)
    {
        List<string> userList = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(durationSeconds);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string userInput = Console.ReadLine();
            userList.Add(userInput);
        }

        return userList;
    }
    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {GetRandomPrompt()} --- ");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine();

        List<string> userList = GetListFromUser(_duration);
        _count = userList.Count();
        Console.WriteLine($"You listed {_count} items!");
        
        DisplayEndingMessage();
    }
}