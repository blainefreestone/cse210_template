public class Scripture
{
    private List<Verse> _verses;
    private List<SimpleReference> _references;
    public string GetDisplayText()
    {
        // Start display text with full reference compiled from list of simple references.
        ComplexReference complexReference = new ComplexReference(_references);
        string displayText = complexReference.GetDisplayText();

        // Add each verse to display text.
        foreach (Verse verse in _verses)
        {
            displayText += verse.GetDisplayText();
            displayText += " ";
        }

        return displayText;
    }
    public void HideInEachVerse()
    {
        // In each verse:
        foreach (Verse verse in _verses) {verse.RandomlyHideWords();}
    }
    public bool IsCompletelyHidden()
    {
        bool isCompletelyHidden = true;
        // Return false if any individual verse isn't completely hidden.
        foreach (Verse verse in _verses)
        {
            if(verse.IsCompletelyHidden()!) {isCompletelyHidden = false;}
        }
        return isCompletelyHidden;
    }
}