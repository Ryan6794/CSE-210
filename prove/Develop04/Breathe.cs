
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.Marshalling;

class Breathe : Activity
{
    static public void Exercise()
    {
        Console.WriteLine($"{_startingMsg} Breathing Activity\n");
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

        int length = GetTime();

        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(length);


        while (currentTime < futureTime)
        {
            Console.Write($"\nBreathe in...");
            Ani(5);
            Console.Write($"\nBreathe out...");
            Ani(5);
            Console.WriteLine("\n");
            currentTime = DateTime.Now;
        }

        Console.WriteLine($"{_endingMsg} {length} of the Breathing Activity\n");
    }

}
