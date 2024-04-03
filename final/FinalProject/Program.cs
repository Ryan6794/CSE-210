

class Program
{
    static void Main(string[] args)
    {

        Library.StartUp();

        var menu = 0;
        while (menu != 4)
        {
            Console.WriteLine("\nMenu Options \n1. Add New Material \n2. List All Materials\n3. List Specific Type of Material\n4. Quit");
            menu = int.Parse(Console.ReadLine());

            if (menu == 1)
            {

                Console.WriteLine("What type of material would you like to add?\n1. Book\n2. Movie\n3. Magazine");
                int NewMat = int.Parse(Console.ReadLine());
                if (NewMat == 1)
                {
                    Console.WriteLine("What type of book?\n1. Non Fiction\n2. Fiction Book");
                    int NewBook = int.Parse(Console.ReadLine());
                    if (NewBook == 1)
                    {
                        Library.NewMat(4);
                    }
                    else if (NewBook == 2)
                    {
                        Library.NewMat(3);
                    }
                }
                else if (NewMat == 2)
                {
                    Library.NewMat(1);
                }
                else if (NewMat == 3)
                {
                    Library.NewMat(2);
                }
            }
            else if (menu == 2)
            {
                Library.DisplayMat();
            }
            else if (menu == 3)
            {
                Console.WriteLine("What type of material would you like to list?\n1. All Books \n2. Fiction Books \n3. Non Fiction Books\n4. Movies\n5. Magazines");
                int type = int.Parse(Console.ReadLine());
                Library.DisplayTypeOfMat(type);
            }
            else if (menu == 4)
            {
                Console.WriteLine("Goodbye");
            }
        }
    }


}
