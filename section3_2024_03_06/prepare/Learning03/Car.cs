class Car
{
    private string make;
    private string model;
    public static int Year = 1999;

    public string GetMake()
    {
        return make;
    }

    public void SetMake(string newMake)
    {
        if (newMake.Length == 0)
        {
            //throw an error
        }
        make = newMake;
    }

    public Car(string make, string model)
    {
        this.make = make;
        this.model = model;
    }

    public void PrintsDetails()
    {
        System.Console.WriteLine($"{make} {model}");
    }

    public static void PrintMakes()
    {
        System.Console.WriteLine("Honda, Ford, ...");
    }
}