
public class Entry
{
    public string response;
    public string prompt;
    public string date;


    public Entry(string response, string prompt);
        this.response = response;
        this.prompt = prompt;


    public static string Prompt()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 5);
        if (randomNumber == 1)
        {
            Console.WriteLine("Who was the most interesting person I interacted with today?");
        }
        if (randomNumber == 2)
        {
            Console.WriteLine("What was the best part of my day?");
        }
        if (randomNumber == 3)
        {
            Console.WriteLine("How did I see the hand of the Lord in my life today?");
        }
        if (randomNumber == 4)
        {
            Console.WriteLine("What was the strongest emotion I felt today?");
        }
        if (randomNumber == 5)
        {
            Console.WriteLine("If I had one thing I could do over today, what would it be?");
        }
        return Console.ReadLine();
    }

    public static string GetDate()
    {
        DateTime now = DateTime.Now;
        return now.ToString("F");
    }



}

