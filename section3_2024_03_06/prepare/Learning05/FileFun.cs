public class FileFun
{

    public static void Run()
    {
        WriteFile("01singleString.txt", "This is the contents of our single string file.");
        var value = ReadFile("01singleString.txt")[0];
        System.Console.WriteLine($"SingleFile = {value}\n");


        WriteValues("02keyValue.txt", "MyKeyGoesHere", 34443);
        var data = ReadValues("02keyValue.txt");
        System.Console.WriteLine($"KeyValues: {data.Key} = {data.Value}\n");


        var origStudent = new Student("studentId", "Bob Builder", "Computer Science");
        WriteStudent("03student.txt", origStudent);
        var readStudent = ReadStudent("03student.txt");
        System.Console.WriteLine("These students should match:");
        System.Console.Write("Original:\t");
        origStudent.Display();
        System.Console.Write("\nFrom File:\t");
        readStudent.Display();


        var people = new List<Person> {
            new Student("studentId", "Bob Builder", "Computer Science"),
            new Employee("employeeId", "Sue Williamns", "CSE")
        };
        WritePeople("04people.txt", people);
        var readPeople = ReadPeople("04people.txt");
        System.Console.WriteLine("\n\nThese people should match:");
        foreach (var person in readPeople)
        {
            person.Display();
            Console.WriteLine();
        }
    }


    // Single Value (where does value save)
    public static void WriteFile(string fileName, string content)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.Write(content);
        }
    }

    public static string[] ReadFile(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);
        return lines;
    }


    // Multiple Values

    public static void WriteValues(string fileName, string key, int value)
    {
        WriteFile(fileName, $"{key}\n{value}");
    }

    public static KeyValuePair<string, int> ReadValues(string fileName)
    {
        var lines = ReadFile(fileName);
        var key = lines[0];
        var value = int.Parse(lines[1]);
        return new KeyValuePair<string, int>(key, value);
    }


    // Instance of a class
    public static void WriteStudent(string fileName, Student student)
    {
        WriteFile(fileName, student.Export());
    }

    public static Student ReadStudent(string fileName)
    {
        var lines = ReadFile(fileName);
        var student = new Student(lines[0]);
        return student;
    }



    // Instances of classes
    public static void WritePeople(string fileName, List<Person> people)
    {
        var data = "";
        foreach (var person in people)
        {
            var typeString = "";
            if (person is Student)
            {
                typeString = "S:";
            }
            else if (person is Employee)
            {
                typeString = "E:";
            }

            data += typeString + person.Export() + "\n";
        }
        WriteFile(fileName, data);
    }

    public static List<Person> ReadPeople(string fileName)
    {
        var lines = ReadFile(fileName);

        var people = new List<Person>();


        var someString = "12345";
        var s1 = someString[0..2]; //12
        var s2 = someString[2..]; //345

        foreach (var line in lines)
        {
            var typeString = line[0..2];
            if (typeString == "S:")
            {
                people.Add(new Student(line[2..]));
            }
            else if (typeString == "E:")
            {
                people.Add(new Employee(line[2..]));
            }
        }

        return people;
    }
}