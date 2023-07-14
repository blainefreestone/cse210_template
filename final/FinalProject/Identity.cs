public class Identity
{
    private string _descriptor;
    private string _description;
    public Identity(string descriptor, string description)
    {
        _descriptor = descriptor;
        _description = description;
    }
    public string GetDisplayText()
    {
        return $"{_description} ({_descriptor})";
    }
    public string GetRepresentationText()
    {
        return $"{_descriptor}|{_description}";
    }
}