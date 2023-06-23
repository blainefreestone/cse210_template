public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;
    public Scripture (Reference reference, string text)
    {
        // Split text into array of words.
        string[] words = text.Split(" ");
        // Create Word instance for each word in array and add to _words.
        foreach (string word in words)
        {
            Word currentWord = new Word(word);
            _words.Add(currentWord);
        }
        
        _reference = reference;
    }
    public string GetDisplayText()
    {
        string displayText = "";

        // Add reference in beginning.
        displayText += _reference.GetDisplayText();
        displayText += " ";

        // Add each word from _words with space in between.
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText();
            displayText += " ";
        }

        return displayText;
    }
    public void RandomlyHideWords()
    {
        Random rnd = new Random();
        int i = 1;
        
        while (i <= 5)
        {
            int randomIndex = rnd.Next(_words.Count);
            // If word isn't already hidden, hide it and add to counter.
            if (_words[randomIndex].IsHidden() == false)
            {
                _words[randomIndex].HideWord();
                i += 1;

                // Check if all words are hidden otherwise gets stuck in infinite loop. 
                bool isCompletelyHidden = true;
                foreach (Word word in _words)
                    {
                        if (word.IsHidden() == false) {isCompletelyHidden = false;}
                    }
                if (isCompletelyHidden == true) {i = 6;}
            }
        }
    }
    public bool IsCompletelyHidden()
    {
        bool isCompletelyHidden = true;
        // Return false if any individual word isn't hidden.
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false) {isCompletelyHidden = false;}
        }
        return isCompletelyHidden;
    }
}