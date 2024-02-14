using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        // Scripture scripture = new Scripture();
        Scripture scripture = new Scripture(new Reference("Proverbs", 3, "5-6"),
        "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        string loop = " ";
        while (loop != "QUIT")
        {

            scripture.Display();
            Console.WriteLine($"\nType QUIT to stop or hit enter to continue");
            loop = Console.ReadLine();
            Console.Clear();
            bool AllHidden = scripture.AreAllWordsHidden();
            if(AllHidden == true)
            {
                loop = "QUIT";
            }
            scripture.HideRandomWords();
        }
    }
}
