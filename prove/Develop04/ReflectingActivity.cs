public class ReflectingActivity : Activity
{
    public ReflectingActivity() : base()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life";
        _prompts.Add("Think of a time you were faced with a difficult situation.");
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
}