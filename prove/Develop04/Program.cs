using System;
using System.IO.Pipes;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        int MenuLoop = 0;

        while (MenuLoop != 4)
        {
            Console.WriteLine("Menu Options: \n1. Start Breathing Activity \n2. Start Reflection Activity \n3. Start Listing Activity \n4. Quit");
            MenuLoop = int.Parse(Console.ReadLine());

            if (MenuLoop == 1)
            {
                Breathe.Exercise();
                
            }
            else if (MenuLoop == 2)
            {
                Reflection.Exercise();
            }
            else if (MenuLoop == 3)
            {
                Listing.Exercise();
            }
            else if (MenuLoop == 4)
            {
                Console.WriteLine("Goodbye");
            }            
        }
    }
}
