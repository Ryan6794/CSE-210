using System.Runtime.CompilerServices;

class Listing : Activity
{
    static Random random = new Random();
    public static void Exercise()
    {

        List<string> prompt = new List<string>
        {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
        };

        Console.WriteLine($"{_startingMsg} Listing Activity\n");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        int length = GetTime();



        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(length);


        RandPrompt(prompt);
        Console.WriteLine("Hit enter when to want to start.");

        while (currentTime < futureTime)
        {
  
            Console.ReadLine();

            currentTime = DateTime.Now;
        }


        Console.WriteLine($"{_endingMsg} {length} of the Listing Activity");
    }

    private static void RandPrompt(List<string> prompt)
    {
        int index = random.Next(prompt.Count);
        Console.WriteLine(prompt[index]);
    }

}