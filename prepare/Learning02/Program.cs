using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

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

        var owner = new Person();
        owner.name = "John";
        owner.phone = "555-2638";
        car.owner = owner;


        cars.Add(car);


        car = new Car();
        car.make = "Ford";
        car.model = "F-150";
        car.year = 2023;
        car.gallons = 30;
        car.milesPerGallon = 5;

        owner = new Person();
        owner.name = "Sue";
        owner.phone = "666-6428";
        car.owner = owner;

        cars.Add(car);


        foreach (var c in cars)
        {
            c.Display();
        }

    }
}


