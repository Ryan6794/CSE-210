using System.IO;

public abstract class Goal
{

    public static readonly string DELIMITER = "~";
    protected int _PointsAwarded;
    protected string _Description;
    protected string _NameOfGoal;

    public Goal(string NameOfGoal, string Description, int PointsAwarded)
    {
        this._NameOfGoal = NameOfGoal;
        this._Description = Description;
        this._PointsAwarded = PointsAwarded;
    }


    public Goal()
    {
        
    }

    public abstract string Save();

    public abstract void Display();

    public abstract int RecordEvent();


}
