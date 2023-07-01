public class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public void Run()
    {
        DisplayStartingMessage();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now <= endTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountdown(4);
            
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountdown(8);
            Console.WriteLine();
        }

        DisplayEndingMessage();

        _runningCount += 1;
        _runningTimeInSeconds += _duration;
    }
}