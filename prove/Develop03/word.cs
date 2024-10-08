using System.Xml.Serialization;

public class Word
{
    public string Text { get; private set; }
    private bool _isHidden;

    public Word(string text)
    {
        Text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _isHidden ? "_____" : Text;
    }
}