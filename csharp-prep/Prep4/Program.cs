using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();
        int number = -1;
        int sum = 0;
        float average;
        int largest = 0;

        Console.WriteLine("Enter a number to add to a list. Enter 0 when done.");
        while (number != 0)
        {
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }

        foreach (int numb in numbers)
        {
            sum = numb + sum;
            if (numb > largest)
                largest = numb;
        }
        average = sum / numbers.Count;
        Console.WriteLine($"The total of the numbers is {sum}.");
        Console.WriteLine($"The average of the numbers is {average}.");
        Console.WriteLine($"The largest of the numbers is {largest}.");
        numbers.Sort();
        foreach (int numb in numbers)
        {
            Console.WriteLine($"{numb}");
        }

    }
}