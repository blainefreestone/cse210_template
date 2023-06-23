public class ComplexReference
{
    private List<SimpleReference> _references;
    public ComplexReference(List<SimpleReference> simpleReferences)
    {
        _references = simpleReferences;
    }
    public string GetDisplayText()
    {
        // TODO: Compile ComplexReference from SimpleReference(s)
        string displayText = "";
        foreach (SimpleReference simpleReference in _references)
        {
            displayText += simpleReference.GetDisplayText();
        }

        return displayText;
    }
}