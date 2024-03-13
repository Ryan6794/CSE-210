namespace learning03;

using System;


class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        //create a new car

        var car = new Car("Honda", "Civic");
        // System.Console.WriteLine($"{car.make} {car.model}");
        car.PrintsDetails();

        car.SetMake("Ford");
        // car.Year = 1999;















        var journal = new Journal();

        var entry = new Entry();
        entry.prompt = "prompt1";
        entry.date = DateTime.Now.ToShortDateString();
        entry.content = "This is the content1";
        entry.tag = "Work";
        journal.entries.Add(entry);

        entry = new Entry();
        entry.prompt = "prompt2";
        entry.date = DateTime.Now.ToShortDateString();
        entry.content = "This is the content2";
        entry.tag = "Home";
        journal.entries.Add(entry);

        var journalText = Export(journal);

        Console.Clear();
        System.Console.WriteLine("Journal Entries: \n=========================");
        System.Console.WriteLine(journalText);








        // A more encapsulated approach
        var journalBetter = new JournalBetter();

        journalBetter.AddEntry(new EntryBetter("prompt1", "This is the content1", "Work"));
        journalBetter.AddEntry(new EntryBetter("prompt2", "This is the content2", "Home"));

        var journalBetterText = journalBetter.Export();

        System.Console.WriteLine("journalBetter Entries: \n=========================");
        System.Console.WriteLine(journalBetterText);
    }

    static string Export(Journal journal)
    {
        string finalExport = "";
        foreach (var entry in journal.entries)
        {
            finalExport += $"{entry.date}{entry.DELIMETER}{entry.prompt}{entry.DELIMETER}{entry.content}{entry.DELIMETER}{entry.tag}" + "\n";
        }
        return finalExport;
    }
}
