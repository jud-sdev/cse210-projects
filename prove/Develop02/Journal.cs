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
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        _entries.Clear();

        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split(',');

            DateTime date = DateTime.Parse(parts[0]);
            string promptText = parts[1];
            string entryText = parts[2];

            Entry loadedEntry = new Entry()
            {
                _date = date.ToString("MM/dd/yyyy"),
                _promptText = promptText,
                _entryText = entryText
            };

            _entries.Add(loadedEntry);
        }
    }

}