public class WritingAssignment : Assignment
{
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }
    private string _title;
    public string GetWritingInfo()
    {
        return $"{_title} by {_studentName}";
    }
}