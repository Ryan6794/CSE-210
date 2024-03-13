using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        var menu = 0;
        Quest quest = new Quest();

        while (menu != 6)
        {
            Console.WriteLine("\nMenu Options \n1. Create New Goal \n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Recorded Event\n6. Quit");
            menu = int.Parse(Console.ReadLine());

            if (menu == 1)
            {
                Console.WriteLine("\nWhat Type of Goal\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
                var GoalType = int.Parse(Console.ReadLine());

                Console.WriteLine("What is the name of the goal?");
                string GoalName = Console.ReadLine();

                Console.WriteLine("What is a short description of the goal?");
                string Description = Console.ReadLine();

                Console.WriteLine("How many point are associated with this goal?");
                int PointsAwarded = int.Parse(Console.ReadLine());

                if (GoalType == 1)
                {

                    Quest.AddGoal(new Simple(GoalName, Description, PointsAwarded));
                }
                else if (GoalType == 2)
                {
                    Quest.AddGoal(new Eternal(GoalName, Description, PointsAwarded));
                }
                else if (GoalType == 3)
                {

                    Console.WriteLine("How many times does this goal need to be do to get a bonus?");
                    int NumberOfTimes = int.Parse(Console.ReadLine());

                    Console.WriteLine("How many bonus point are associated with completing this goal?");
                    int BonusPointsAwarded = int.Parse(Console.ReadLine());

                    Quest.AddGoal(new CheckList(GoalName, Description, PointsAwarded, BonusPointsAwarded,NumberOfTimes));
                }

            }
            else if (menu == 2)
            {
                Quest.DisplayGoals();
            }
            else if (menu == 3)
            {
                Quest.SaveGoals();
            }
            else if (menu == 4)
            {
                Quest.LoadGoals();
            }
            else if (menu == 5)
            {
                Quest.RecordEvent();
            }
            else if (menu == 6)
            {
                Console.WriteLine("Goodbye");
            }
        }
    }
}
