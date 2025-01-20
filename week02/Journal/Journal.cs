using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach(Entry entry in _entries)
            {
            outputFile.WriteLine($"\nDate: {entry._date} - Prompt: {entry._promptText}\n{entry._entryText}");
            }
        }

    }

    public void LoadFromFile(string file)
    {
        string[] lines = File.ReadAllLines(file);
        _entries.Clear();

        foreach (var line in lines)
        {
            Entry entry = new Entry
            {
                _entryText = line
            };
            _entries.Add(entry);
        }
    }
}