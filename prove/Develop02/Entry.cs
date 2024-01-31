//Author Ryan Lyman

public class Entry
{
    public string response;
    public string prompt;
    public string date;


    public Entry(string response, string prompt, string date)
    {
        this.response = response;
        this.prompt = prompt;
        this.date = date;
    }

    public Entry(string import)
    {
        var parts = import.Split("|");
        this.date = parts[0];
        this.prompt = parts[1];
        this.response = parts[2];

    }


    public string Export()
    {
        return $"(date)|(prompt)|(response)";
    }


    public static string Prompt()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 5);
        if (randomNumber == 1)
        {
            return "Who was the most interesting person I interacted with today?";
        }
        if (randomNumber == 2)
        {
            return "What was the best part of my day?";
        }
        if (randomNumber == 3)
        {
            return "How did I see the hand of the Lord in my life today?";
        }
        if (randomNumber == 4)
        {
            return "What was the strongest emotion I felt today?";
        }
        if (randomNumber == 5)
        {
            return "If I had one thing I could do over today, what would it be?";
        }
        return "Fail";
    }

    public static string GetDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        return dateText;

    }

    public string DisplayString()
    {
        return $"{date} {prompt} {response}";
    }
}

