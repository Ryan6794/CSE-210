
using System.Diagnostics.CodeAnalysis;

class Quest
{

    private static int _totalPoints;
    private static List<Goal> GoalsList = new List<Goal>();

    public static void DisplayGoals()
    {
        int i = 1;
        foreach (var Goal in GoalsList)
        {
            Console.Write($"{i}. ");
            Goal.Display();
            i++;
        }
    }

    public static void AddGoal(Goal goal)
    {
        GoalsList.Add(goal);
    }


    public static void SaveGoals()
    {
        Console.WriteLine("Where do you want to write your to file?");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_totalPoints);
            foreach (var Goal in GoalsList)
            {
                string output = Goal.Save();
                outputFile.WriteLine(output);
            }
        }
    }


    public static void LoadGoals()
    {
        Console.WriteLine("What file do you want to read from?");
        string fileName = Console.ReadLine();
        string[] lines = File.ReadAllLines(fileName);
        _totalPoints = int.Parse(lines[0]);

        foreach (string line in lines.Skip(1))
        {
        
            string[] parts = line.Split("~", 2);

            var GoalType = parts[0];
            var GoalData = parts[1];
            switch (GoalType)
            {
                case "Simple":
                    AddGoal(new Simple(GoalData));
                    break;

                case "Eternal":
                    AddGoal(new Eternal(GoalData));
                    break;

                case "CheckList":
                    AddGoal(new CheckList(GoalData));
                    break;
            }

        }
    }


    public static void RecordEvent()
    {
        Console.WriteLine("What goal do you want to record an event for?");
        DisplayGoals();

        int menu = int.Parse(Console.ReadLine());
        int index = menu - 1;

        if (index >= 0 && index < GoalsList.Count)
        {
            int pointsEarned = GoalsList[index].RecordEvent();
            _totalPoints += pointsEarned;

            Console.WriteLine($"You earned {pointsEarned} points for this event.");
            Console.WriteLine($"You have {_totalPoints} total points");
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }
}
