using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment assignment1 = new Assignment("Alex Tomson", "Sci");
        MathAssignment mathAssignment1 = new MathAssignment("John Smith", "Math", "Section 7.3", "1-7");
        WritingAssignment writingAssignment1 = new WritingAssignment("Mary Sue", "Post WW2", "The Cold War");

        Console.WriteLine(assignment1.GetSummary());

        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());

        Console.WriteLine(writingAssignment1.GetSummary());
        Console.WriteLine(writingAssignment1.GetWritingInformation());



    }
}