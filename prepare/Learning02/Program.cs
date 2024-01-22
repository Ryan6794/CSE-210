using System;
using System.Net.WebSockets;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        // var cars = new List<Car>();

        // Car car = new Car();
        // car.make = "Honda";
        // car.model = "Civic";
        // car.gallons = 10;
        // car.milesPerGallon = 30;

        // var owner = new Person();
        // owner.name = "John";
        // owner.phone = "555-2638";
        // car.owner = owner;


        // cars.Add(car);


        // car = new Car();
        // car.make = "Ford";
        // car.model = "F-150";
        // car.year = 2023;
        // car.gallons = 30;
        // car.milesPerGallon = 5;

        // owner = new Person();
        // owner.name = "Sue";
        // owner.phone = "666-6428";
        // car.owner = owner;

        // cars.Add(car);


        // foreach (var c in cars)
        // {
        //     c.Display();
        // }

        Job job1 = new Job();
        job1._jobTitle = "Software Dev";
        job1._company = "IBM";
        job1._endYear = 2021;
        job1._startYear = 1999;

        job1.Display();


        Job job2 = new Job();
        job2._jobTitle = "HR";
        job2._company = "Apple";
        job2._endYear = 2024;
        job2._startYear = 2021;

        job2.Display();

        var person = new Resume();
        person._name = "Jonny";
        person._jobs.Add(job1);
        person._jobs.Add(job2);

        person.Display();





    }
}


