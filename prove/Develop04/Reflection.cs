using System.Diagnostics.CodeAnalysis;

class Reflection : Activity
{
    static Random random = new Random();

    private static List<string> prompt = new List<string>{
        "Think of a time when you stood up for someone else.\n",
        "Think of a time when you did something really difficult.\n",
        "Think of a time when you helped someone in need.\n",
        "Think of a time when you did something truly selfless.\n"
        };

    private static List<string> question = new List<string>{
        "\n\nWhy was this experience meaningful to you?",
        "\n\nHave you ever done anything like this before?",
        "\n\nHow did you get started?",
        "\n\nHow did you feel when it was complete?",
        "\n\nWhat made this time different than other times when you were not as successful?",
        "\n\nWhat is your favorite thing about this experience?",
        "\n\nWhat could you learn from this experience that applies to other situations?",
        "\n\nWhat did you learn about yourself through this experience?",
        "\n\nHow can you keep this experience in mind in the future?"
        };

    public static void Exercise()
    {
        Console.WriteLine($"{_startingMsg} Reflection Activity\n");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        int length = GetTime();

        RandPrompt(prompt);
        Console.Write("Hit enter when you have an experience in mind.");
        Console.ReadLine();


        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(length);

        while (currentTime < futureTime)
        {
            RandQuestion(question);
            Console.Write("Keep Thinking...");
            Ani(9);

            currentTime = DateTime.Now;
        }
        Console.WriteLine($"{_endingMsg} {length} of the Reflection Activity");

    }

    private static void RandPrompt(List<string> prompt)
    {
        int index = random.Next(prompt.Count);
        Console.WriteLine(prompt[index]);
    }

    private static void RandQuestion(List<string> question)
    {
        int index = random.Next(question.Count);
        Console.WriteLine(question[index]);
    }

}