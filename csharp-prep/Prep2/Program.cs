using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        //data types
        int i;
        long l;
        float f;
        double d;
        char c;
        string s;
        byte b;
        bool b2;


        //variables
        int myCount = 4;
        string aName = "bob";


        //var 
        var anotherCount = 4;

        //anotherCount = 3.4;

        //printing Variables 
        Console.Write("What is your age?");

        //Readline

        var ageString = Console.ReadLine();

        System.Console.WriteLine($"My age is {ageString}.");
        System.Console.WriteLine("My age is" +{
            ageString + ".");

            //convering Var 
            int age = int.Parse(ageString);


            //Conditionals
            if (age < 18)
            {
                System.Console.WriteLine("You're a minor.");
                System.Console.WriteLine("Another string to print");
            }
            else
            {
                System.Console.WriteLine("You're Old");
            }

        }
    }