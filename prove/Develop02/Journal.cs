
public class Journal
{
    public List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public Journal(string import)
    {

    }

    public void Display()
    {
        foreach(string entry in entries)
        {
            Console.WriteLine("");
        }

    }

    public static string Export()
    {
        return "";
    }

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

}