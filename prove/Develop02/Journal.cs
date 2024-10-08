public class Journal
{
    private List<Entry> _entries = new List<Entry>();
    private PromptGenerator _promptGenerator = new PromptGenerator();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public string GetRandomPrompt()
    {
        return _promptGenerator.GetRandomPrompt();
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries) 
        {
            entry.Display();
            Console.WriteLine();       
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine(entry.ToString());
            }
        }
        Console.WriteLine("Journal Saved to " + filename);
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    string date = parts[0];
                    string promptText = parts[1];
                    string entryText = parts[2];
                    Entry entry = new Entry(date, promptText, entryText);
                    _entries.Add(entry);
                }
            }
        }
        Console.WriteLine("Journal loaded from " + filename);
    }
}