// Author Ryan Lyman
using System.Runtime.CompilerServices;

public class Journal
{
    public List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }



    public void Display()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry.DisplayString());
        }
    }



    public void AddEntry()
    {
        string prompt = Entry.Prompt();
        string response = GatherInput(prompt);
        string date = Entry.GetDate();
        var entry = new Entry(response, prompt, date);
        entries.Add(entry);

    }

    private string GatherInput(string prompt)
    {
        Console.WriteLine(prompt);
        return Console.ReadLine();
    }




    public string[] Export()
    {
        var exportLines = new List<string>();
        foreach (var entry in entries)
        {
            exportLines.Add(entry.Export());
        }
        return exportLines.ToArray();
    }




}