
using System.IO;
using System.Drawing;

public class Simple : Goal
{

    private bool _IsCompleted;

    public Simple(string NameOfGoal, string Description, int PointsAwarded) : base(NameOfGoal, Description, PointsAwarded)
    {

    }


    public Simple(string GoalData)
    {
        string[] parts = GoalData.Split(DELIMITER);
        _NameOfGoal = parts[0];
        _Description = parts[1];
        _PointsAwarded = int.Parse(parts[2]);
        _IsCompleted = bool.Parse(parts[3]);

    }

    public override string Save()
    {
        return $"Simple{DELIMITER}{_NameOfGoal}{DELIMITER}{_Description}{DELIMITER}{_PointsAwarded}{DELIMITER}{_IsCompleted}";
    }



    public override void Display()
    {
        if (_IsCompleted == false)
        {
            Console.WriteLine($"[ ] {_NameOfGoal} ({_Description}): {_PointsAwarded} Points ");
        }
        else
        {
            Console.WriteLine($"[X] {_NameOfGoal} ({_Description}): {_PointsAwarded} Points ");
        }
    }


    public override int RecordEvent()
    {
        if (_IsCompleted == true)
        {
            Console.WriteLine("Goal is already done.");
            return 0;
        }
        else
        {
            _IsCompleted = true;
            Console.WriteLine("Good job.");
            return _PointsAwarded;
        }
    }
}
