using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

public class Entry
{
    private string _date;
    private string _promptText;
    private string _entryText;

    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
    }

    public override string ToString()
    {
        return $"{_date}|{_promptText}|{_entryText}";
    }
}