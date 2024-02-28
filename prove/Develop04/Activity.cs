using System.ComponentModel.DataAnnotations;

class Activity
{
    protected static string _startingMsg = "Welcome to the";
    protected static string _endingMsg = "You have completed another";

    protected static void Ani(int length)
    {
        for (int i = length; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }

    protected static int GetTime()
    {
        Console.WriteLine("How many seconds do you want to do this activity for?");
        int length = int.Parse(Console.ReadLine());
        return length;
    }


    // protected bool Clock(int length)
    // {
    //     DateTime startTime = DateTime.Now;
    //     DateTime futureTime = startTime.AddSeconds(length);


    //     DateTime currentTime = DateTime.Now;
    //     if (currentTime < futureTime)
    //     {
    //         Console.WriteLine("We have not arrived at our future time yet...");
    //     }
    //     return true;
    // }

}
