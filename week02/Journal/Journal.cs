using System.IO; 

public class Journal
{
    public List<Entry> _entries;

    public void AddEntry(Entry newEntry)
    {
        
    }

    public void DisplayAll()
    {

    }

    public void SaveToFile(string file)
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine();
        }

    }

    public void LoadFromFile(string file)
    {
        
    }
}