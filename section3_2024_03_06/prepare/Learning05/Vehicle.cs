using System.Security.Cryptography.X509Certificates;

public class VehicleRunner
{
    public static void Run()
    {
        Car car1 = new Car("Honda", "Accord", 10, 33);
        car1.Display();
        Truck truck1 = new Truck("Toyota", "Tundra", 20, 15, false);
        truck1.Display();
        Truck truck2 = new Truck("Toyota", "Tundra", 20, 15, true);

        // Vehicle
        var vehicles = new List<Vehicle> { car1, truck1, truck2 };

        foreach (var vehicle in vehicles)
        {
            System.Console.WriteLine($"{vehicle.Display()}: {vehicle.RangeInMiles()} miles remaining");
        }
    }
}

public class Vehicle
{
    private string make;
    private string model;
    private int gallons;
    private int milePerGallon;

    public Vehicle(string make, string model, int gallons, int milesPerGallon)
    {
        this.make = make;
        this.model = model;
        this.gallons = gallons;
        this.milePerGallon = milesPerGallon;
    }

    public virtual string Display()
    {
        return $"{make} {model}";
    }

    public virtual double RangeInMiles()
    {
        return milePerGallon * gallons;
    }
}

public class Car : Vehicle
{
    public Car(string make, string model, int gallons, int milesPerGallon) : base(make, model, gallons, milesPerGallon)
    { }
}

public class Truck : Vehicle
{
    private bool isTowing;

    public Truck(string make, string model, int gallons, int milesPerGallon, bool isTowing) : base(make, model, gallons, milesPerGallon)
    {
        this.isTowing = isTowing;
    }

    // Update Display to indicate if they are towing (virtual)
    public override string Display()
    {
        return $"{base.Display()} isTowing={isTowing}";
    }

    // Override RangeInMiles to account for isTowing (virtual)


    public override double RangeInMiles()
    {
        // var reduction = 1.0;
        // if (isTowing)
        // {
        //     reduction = 0.7;
        // }
        var reduction = isTowing ? 0.7 : 1.0;
        return base.RangeInMiles() * reduction;
    }
}