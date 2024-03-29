
class Library
{

    private static List<Material> MaterialList = new List<Material>();



    public static void StartUp()
    {
        Movie movie1 = new Movie("PG", "1H 26M", "Madagascar", 00001, "Pixar", "Animation / Adventure", "2005");
        Magazine magazine1 = new Magazine("John Doe", "Home Decor", 00002, "Decor Publishing", "Design", "2024-03-27");
        FicBook ficBook1 = new FicBook("J. SMI-202", 9780123456789, "John Smith", "Dragons and Stuff", 00003, "XYZ Publishers", "Fantasy", "2022-07-12");
        NonFicBook nonFicBook1 = new NonFicBook(532.7, 4230123456789, "Jane Doe", "The Fall of Rome", 00004, "ABC Publishers", "History", "2012-09-24");


        MaterialList.Add(movie1);
        MaterialList.Add(magazine1);
        MaterialList.Add(ficBook1);
        MaterialList.Add(nonFicBook1);
    }



    public static void DisplayMat()
    {
        foreach (Material Mat in MaterialList)
        {
            Mat.Display();
        }
    }

    public static void NewMat()
    {
        
    }

}