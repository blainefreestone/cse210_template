public class Activity
{
    public Activity()
    {
        _name = "untitled";
        _description = "no description";
        _duration = 0;
        _runningCount = 0;
        _runningTimeInSeconds = 0;
    }
    protected string _name;
    protected string _description;
    protected int _duration;
    protected int _runningCount;
    protected int _runningTimeInSeconds;
    public int GetTimeInSeconds()
    {
        return _runningTimeInSeconds;
    }
    public int GetCount()
    {
        return _runningCount;
    }
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well Done!!");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
    }
    public void ShowSpinner(int durationSeconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(durationSeconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(animationStrings[i]);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }
    public void ShowCountdown(int durationSeconds)
    {
        for (int i = durationSeconds; i >= 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}