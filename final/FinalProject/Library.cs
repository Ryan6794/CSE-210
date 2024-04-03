
class Library
{
    private static string title;
    private static int catalogNumber;
    private static string publisher;
    private static string genre;
    private static string releaseDate;
    private static List<Material> materialList = new List<Material>();

    public static void StartUp()
    {
        Movie movie1 = new Movie("PG", "1H 26M", "Madagascar", 1111, "Pixar", "Animation / Adventure", "2005");
        Magazine magazine1 = new Magazine("John Doe", "Home Decor", 2222, "Decor Publishing", "Design", "2024-03-27");
        FicBook ficBook1 = new FicBook("J. SMI-202", 9780123456789, "John Smith", "Dragons and Stuff", 3333, "XYZ Publishers", "Fantasy", "2022-07-12");
        NonFicBook nonFicBook1 = new NonFicBook(532.7, 4230123456789, "Jane Doe", "The Fall of Rome", 4444, "ABC Publishers", "History", "2012-09-24");


        materialList.Add(movie1);
        materialList.Add(magazine1);
        materialList.Add(ficBook1);
        materialList.Add(nonFicBook1);
    }



    public static void DisplayMat()
    {
        foreach (Material Mat in materialList)
        {
            Mat.Display();
        }
    }

    public static void DisplayTypeOfMat(int type)
    {


        IEnumerable<Material> filteredMaterials = null;

        switch (type)
        {
            case 1:
                filteredMaterials = materialList.OfType<Book>();
                break;
            case 2:
                filteredMaterials = materialList.OfType<FicBook>();
                break;
            case 3:
                filteredMaterials = materialList.OfType<NonFicBook>();
                break;
            case 4:
                filteredMaterials = materialList.OfType<Movie>();
                break;
            case 5:
                filteredMaterials = materialList.OfType<Magazine>();
                break;
            default:
                Console.WriteLine("Not a valid entry.");
                return;
        }

        foreach (Material Mat in filteredMaterials)
        {
            Mat.Display();
        }
    }

    public static void NewMat(int type)
    {
        switch (type)
        {
            case 1:
                Console.WriteLine("Enter movie details:");
                Console.WriteLine("Rating:");
                string rating = Console.ReadLine();
                Console.WriteLine("Duration (__H __M):");
                string duration = Console.ReadLine();
                GetInfo();
                Movie newMovie = new Movie(rating, duration, title, catalogNumber, publisher, genre, releaseDate);
                materialList.Add(newMovie);
                break;
            case 2:
                Console.WriteLine("Enter magazine details:");
                Console.WriteLine("Illustrator:");
                string illustrator = Console.ReadLine();
                GetInfo();
                Magazine newMag = new Magazine(illustrator, title, catalogNumber, publisher, genre, releaseDate);
                materialList.Add(newMag);
                break;
            case 3:
                Console.WriteLine("Enter fiction book details:");
                Console.WriteLine("Author Code:");
                string authorCode = Console.ReadLine();
                Console.WriteLine("Author:");
                string author = Console.ReadLine();
                Console.WriteLine("ISBN:");
                long ISBN = long.Parse(Console.ReadLine());
                GetInfo();
                FicBook newFicBook = new FicBook(authorCode, ISBN, author, title, catalogNumber, publisher, genre, releaseDate);
                materialList.Add(newFicBook);
                break;
            case 4:
                Console.WriteLine("Enter non-fiction book details:");
                Console.WriteLine("Dewey Decimal:");
                double DeweyDecimal = double.Parse(Console.ReadLine());
                Console.WriteLine("Author:");
                author = Console.ReadLine();
                Console.WriteLine("ISBN:");
                ISBN = long.Parse(Console.ReadLine());
                GetInfo();
                NonFicBook newNonFicBook = new NonFicBook(DeweyDecimal, ISBN, author, title, catalogNumber, publisher, genre, releaseDate);
                materialList.Add(newNonFicBook);
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }


    static void GetInfo()
    {
        Console.WriteLine("What is the Title?");
        title = Console.ReadLine();
        Console.WriteLine("What is the 4 digit Catalog Number?");
        catalogNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the Publisher?");
        publisher = Console.ReadLine();
        Console.WriteLine("What is the Genre?");
        genre = Console.ReadLine();
        Console.WriteLine("What is the Release Date?");
        releaseDate = Console.ReadLine();
    }
}