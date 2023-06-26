public class Assignment
{
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    
    private string _studentName;
    private string _topic;
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}