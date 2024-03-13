namespace learning03;

public class Journal
{
    public List<Entry> entries = new List<Entry>();

}

/// //////////////////////////////////////////////////////////

public class JournalBetter
{
    private List<EntryBetter> entries = new List<EntryBetter>();

    public void AddEntry(EntryBetter entry)
    {
        entries.Add(entry);
        Console.WriteLine("Added entry to journal");
    }

    public string Export()
    {
        string finalExport = "";
        foreach (var entry in entries)
        {
            finalExport += entry.Export() + "\n";
        }
        return finalExport;
    }
}