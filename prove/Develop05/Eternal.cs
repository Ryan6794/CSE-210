using System.IO;


class Eternal : Goal
{

    public Eternal(string NameOfGoal, string Description, int PointsAwarded) : base(NameOfGoal, Description, PointsAwarded)
    {

    }

    public Eternal(string GoalData)
    {
        string[] parts = GoalData.Split(DELIMITER);
        _NameOfGoal = parts[0];
        _Description = parts[1];
        _PointsAwarded = int.Parse(parts[2]);

    }



    public override string Save()
    {
        return $"Eternal{DELIMITER}{_NameOfGoal}{DELIMITER}{_Description}{DELIMITER}{_PointsAwarded}";
    }



    public override void Display()
    {
        Console.WriteLine($"[ ] {_NameOfGoal} ({_Description}): {_PointsAwarded} Points");
    }


    public override int RecordEvent()
    {
        return _PointsAwarded;
    }

}
