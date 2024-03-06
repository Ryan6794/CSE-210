using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Student s1 = new Student("0987654321", "Sam", "CIT");
        Faculty f1 = new Faculty("1234567890", "John", "CSE");

        List<Person> peopleList = new List<Person>();
        peopleList.Add(s1);
        peopleList.Add(f1);


        foreach (var person in peopleList)
        {
            // person.major; 

            // Console.WriteLine($"{person.DisplayInfo()}");
            if (person is Student)
            {
                Student student = (Student)person;
                student.Display();
            }
            else
            {
                Faculty faculty = (Faculty)person;
                faculty.Display();
            }
        }
    }
}


class Person
{
    private string id;
    private string name;

    public Person(string id, string name)
    {
        this.id = id;
        this.name = name;
    }


    public virtual void Display()
    {
        Console.WriteLine($"{name}: {id}");
        
    }
}

class Student : Person
{
    private string major;

    public Student(string id, string name, string major) : base(id, name)
    {
        this.major = major;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"\t{major}");
    }
}


class Faculty : Person
{
    private string department;

    public Faculty(string id, string name, string department) : base(id, name)
    {
        this.department = department;
    }


    public override void Display()
    {
        base.Display();
        Console.WriteLine($"\t{department}");
    }

}