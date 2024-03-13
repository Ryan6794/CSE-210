
using System.IO;
using System.Drawing;
using System.Reflection;

class CheckList : Goal
{

    private bool _IsCompleted;
    private int _bonusPoints;
    private int _TotalNumberOfTimes;
    private int _TimesDone;

    public CheckList(string NameOfGoal, string Description, int PointsAwarded, int bonusPoints, int NumberOfTimes) : base(NameOfGoal, Description, PointsAwarded)
    {
        this._bonusPoints = bonusPoints;
        this._TotalNumberOfTimes = NumberOfTimes;
    }


    public CheckList(string GoalData)
    {
        string[] parts = GoalData.Split(DELIMITER);
        _NameOfGoal = parts[0];
        _Description = parts[1];
        _PointsAwarded = int.Parse(parts[2]);
        _bonusPoints = int.Parse(parts[3]);
        _TimesDone = int.Parse(parts[4]);
        _TotalNumberOfTimes = int.Parse(parts[5]);


    }

    public override string Save()
    {
        return $"CheckList{DELIMITER}{_NameOfGoal}{DELIMITER}{_Description}{DELIMITER}{_PointsAwarded}{DELIMITER}{_bonusPoints}{DELIMITER}{_TimesDone}{DELIMITER}{_TotalNumberOfTimes}";
    }


    public override void Display()
    {

        if (_IsCompleted == true)
        {
            Console.WriteLine($"[X] {_NameOfGoal} ({_Description}): {_PointsAwarded} Points");
        }
        else
        {
            Console.WriteLine($"[ ] {_NameOfGoal} ({_Description}): {_PointsAwarded} Points -- Currently Completed {_TimesDone}/{_TotalNumberOfTimes}");
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
            _TimesDone = _TimesDone + 1;
            if(_TimesDone < _TotalNumberOfTimes)
            {
                Console.WriteLine($"Keep up the good work! Only {_TotalNumberOfTimes - _TimesDone} left.");
                return _PointsAwarded;
            }
            else
            {
                Console.WriteLine("Good job.");
                _IsCompleted = true;
                return _PointsAwarded + _bonusPoints;
            }

        }

    }

}
