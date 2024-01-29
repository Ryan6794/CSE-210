using System;
using System.ComponentModel;
using System.IO;
using System.Net;


class Program
{
    static public Journal journal;

    static void Main(string[] args)
    {
        journal = new Journal();

        Console.WriteLine("Welcome to the Journal Program");
        int Menu = 0;
        while (Menu != 5)
        {
            Menu = ShowMenu();
            if (Menu == 1)
            {
                string prompt = Entry.Prompt();
                string response = GatherInput(prompt);
                var entry = new Entry(response, prompt);

                journal.AddEntry(entry);
            }
            if (Menu == 2)
            {
                journal.Display();
            }
            if (Menu == 3)
            {
                SaveToFile();
            }
            if (Menu == 4)
            {
                LoadFromFile();
            }
            if (Menu == 5)
            {
                Console.WriteLine("Goodbye");
            }
            Console.Clear();
        }

    }

    static int ShowMenu()
    {
        Console.WriteLine($"What would you like to do? \n 1 Write new entry \n 2 Display current entries \n 3 Save to file \n 4 Load from file \n 4 Exit");
        return int.Parse(Console.ReadLine());
    }

    private static string GatherInput(string prompt)
    {
        Console.WriteLine(prompt);
        return Console.ReadLine();
    }
    public void Run()
    {

    }

    public static void SaveToFile()
    {
        Console.WriteLine("What file do you want to save to?");
        string fileName = Console.ReadLine();


        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"My favorite color is {Journal.Export()}");
        }
    }

    public static void LoadFromFile()
    {
        Console.WriteLine("What file do you want to read from?");
        string FileName = Console.ReadLine();

    }
}
