using System.IO.Pipes;

class Car
{
    public string model;
    public string make;
    public int year;
    public int milesPerGallon;
    public int gallons;
    public Person owner;

    public int TotalRange()
    {
        return gallons * milesPerGallon;
    }

    public void Display()
    {
        Console.WriteLine($"{make} {model} {year} {owner.DisplayString()}: totalRange = {TotalRange()}");
    }


}

