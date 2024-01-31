//Author Ryan Lyman
using System;
using System.IO;


class Program
{

    static void Main(string[] args)
    {
        Journal journal = new Journal();

        Console.WriteLine("Welcome to the Journal Program");

        int Menu = 0;
        while (Menu != 5)
        {
            Menu = ShowMenu();
            if (Menu == 1)
            {
                journal.AddEntry();
            }
            if (Menu == 2)
            {
                journal.Display();
            }
            if (Menu == 3)
            {
                var lines = journal.Export();
                SaveToFile(lines);
            }
            if (Menu == 4)
            {
                var lines = LoadFromFile();
                journal = new Journal();
            }
            if (Menu == 5)
            {
                Console.WriteLine("Goodbye");
            }
        }
    }

    static int ShowMenu()
    {
        Console.WriteLine($"What would you like to do? \n 1 Write new entry \n 2 Display current entries \n 3 Save to file \n 4 Load from file \n 5 Exit");
        return int.Parse(Console.ReadLine());
    }


    static string[] LoadFromFile()
    {
        Console.WriteLine("What file do you want to read from?");
        var filename = Console.ReadLine();
        return System.IO.File.ReadAllLines(filename);

    }


    static void SaveToFile(string[] lines)
    {
        Console.WriteLine("What file do you want to save to?");
        var filename = Console.ReadLine();



        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(lines);
            System.IO.File.WriteAllLines(filename, lines);
        }
    }
}
