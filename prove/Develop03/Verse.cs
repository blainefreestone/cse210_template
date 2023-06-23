public class Verse
{
    private List<Word> _words;
    private SimpleReference _reference;
    public Verse(SimpleReference reference, string text)
    {
        // Split text into array of words.
        string[] words = text.Split(" ");
        // Create Word instance for each word in array and add to _words.
        foreach (string word in words)
        {
            Word currentWord = new Word(text);
            _words.Add(currentWord);
        }
        
        _reference = reference;
    }
    public string GetDisplayText()
    {
        // Add each word from _words with space in between.
        string displayText = "";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText();
            displayText += " ";
        }
        
        return displayText;
    }
    public bool IsCompletelyHidden()
    {
        bool isCompletelyHidden = true;
        // Return false if any individual word isn't hidden.
        foreach (Word word in _words)
        {
            if (word.IsHidden()!) {isCompletelyHidden = false;}
        }
        return isCompletelyHidden;
    }
    public void RandomlyHideWords()
    {
        Random rnd = new Random();
        int i = 1;
        while (i <= 3)
        {
            int randomIndex = rnd.Next(_words.Count);
            // If word isn't already hidden, hide it and add to counter.
            if (_words[randomIndex].IsHidden()!)
            {
                _words[randomIndex].HideWord();
                i += 1;
            }
        }
    }
}