using System;

class Program
{
    static void Main(string[] args)
    {

        int gradePercent;
        Console.WriteLine("What is your grade percent?");
        string gradeInput = Console.ReadLine();
        gradePercent = int.Parse(gradeInput);
        string letter = "";


        if (gradePercent >= 90)
        {
            letter = "A";

        }
        else if (gradePercent >= 80)
        {
            letter = "B";

        }
        else if (gradePercent >= 70)
        {
            letter = "C";
        }
        else if (gradePercent >= 60)
        {
            letter = "D";
        }
        else if (gradePercent < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");


        if (gradePercent > 70)
        {
            Console.WriteLine("Congrats you passed!");
        }
        else
        {
            Console.WriteLine("Sorry you failed. Better luck next time.");
        }


    }
}