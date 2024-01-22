using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        var cars = new List<Car>();

        Car car = new Car();
        car.make = "Honda";
        car.model = "Civic";
        car.gallons = 10;
        car.milesPerGallon = 30;

        cars.Add(car);


        car = new Car();
        car.make = "Ford";
        car.model = "F-150";
        car.year = 2023;
        car.gallons = 30;
        car.milesPerGallon = 5;

        cars.Add(car);


        foreach (var c in cars)
        {
           c.Display();
        }

    }
}


