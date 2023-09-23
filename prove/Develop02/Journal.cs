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
        using StreamWriter saveFile = new StreamWriter(file);
        foreach (Entry entry in _entries)
        {
            saveFile.WriteLine(entry._entryText);
        }
    }

public void LoadFromFile(string file)
{
    _entries.Clear();

    if (File.Exists(file) != true)
    {
       Console.WriteLine($"The {file} file did not exist. Please enter a correct file name.");
       
    }

    else if (File.Exists(file))
    {
    string[] lines = System.IO.File.ReadAllLines(file);

    foreach (string line in lines)
    {
        _entries.Add(new Entry { _entryText = line });
    }
    }
}

}