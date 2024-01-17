using System;
using System.Globalization;

class Program
{


    static void DisplayWelcome()
    {
        Console.WriteLine($"Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number?");
        int favnumb = int.Parse(Console.ReadLine());
        return favnumb;
    }

    static int SquareNumber(int numb)
    {
        int squareNumb = numb * numb;
        return squareNumb;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        DisplayWelcome();
        string name = PromptUserName();
        int numb = PromptUserNumber();
        int square = SquareNumber(numb);
        DisplayResult(name,square);






        // int Add2(int number)
        // {
        //     Console.WriteLine($"{number}");
        //     return number + 2;
        // }

        // void PrintName(string name)
        // {
        //     Console.WriteLine(name);
        // }

        // int answer = Add2(10);
        // PrintName($"Bob is {answer}");

        // var i = 12;
        // {
        //     var y = 10;
        //     y = i + 5;
        //     i = y + 4;
        // }


    }
}