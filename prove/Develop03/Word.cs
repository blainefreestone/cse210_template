public class Word
{
    private string _text;
    private int _wordLength;
    private bool _isHidden;
    public Word(string text)
    {
        _text = text;
        _wordLength = _text.Length;
        _isHidden = false;
    }
    public void HideWord()
    {
        _text = String.Concat(Enumerable.Repeat("_", _wordLength));
        _isHidden = true;
    }
    public void ShowWord()
    {
        Console.Write(_text);
    }
    public bool IsHidden()
    {
        if (_isHidden == true) {return true;}
        else {return false;}
    }
    public string GetDisplayText()
    {
        return _text;
    }
}