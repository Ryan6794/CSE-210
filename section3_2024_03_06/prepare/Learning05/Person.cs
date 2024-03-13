public class PersonRunner
{
    public static void Run()
    {
        //People
        var people = new List<Person> {
            new Student("id1", "Student1", "Software Engineering"),
            new Employee("id2", "Employee2", "CSEE")
        };

        foreach (var person in people)
        {
            person.Display();
            System.Console.WriteLine();
        }
    }
}


public class Person
{
    public static readonly string DELIMITER = "~";

    private string id;
    private string name;

    public Person(string id, string name)
    {
        this.id = id;
        this.name = name;
    }

    public Person(string values)
    {
        var personValues = values.Split(DELIMITER);
        id = personValues[0];
        name = personValues[1];
    }

    public virtual void Display()
    {
        Console.Write($"{name}\t{id}");
    }

    public virtual string Export()
    {
        return $"{id}{DELIMITER}{name}";
    }
}

// Student
public class Student : Person
{
    private string major;

    public Student(string studentId, string studentName, string major) : base(studentId, studentName)
    {
        this.major = major;
    }
    //studentId~Bob Builder~~Computer Science
    public Student(string values) : base(values.Split($"{Person.DELIMITER}{Person.DELIMITER}")[0])
    {
        var studentValues = values.Split($"{Person.DELIMITER}{Person.DELIMITER}")[1].Split(Person.DELIMITER);
        major = studentValues[0];
    }

    public override string Export() //studentId~Bob Builder~~Computer Science
    {
        return base.Export() + $"{DELIMITER}{DELIMITER}{major}";
    }

    public override void Display()
    {
        base.Display();
        Console.Write($"\t{major}");
    }
}

// Employee
public class Employee : Person
{
    private string department;

    public Employee(string id, string name, string department) : base(id, name)
    {
        this.department = department;
    }

    // Override Display to show department
    public override string Export()
    {
        return base.Export() + $"{DELIMITER}{DELIMITER}{department}";
    }

    public Employee(string values) : base(values.Split($"{Person.DELIMITER}{Person.DELIMITER}")[0])
    {
        var employeeValues = values.Split($"{Person.DELIMITER}{Person.DELIMITER}")[1].Split(Person.DELIMITER);
        department = employeeValues[0];
    }

    public override void Display()
    {
        base.Display();
        Console.Write($"\t{department}");
    }
}
