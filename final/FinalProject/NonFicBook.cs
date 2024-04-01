
class NonFicBook : Book
{

    private double _DeweyDec;


    public NonFicBook(double DeweyDec, long ISBN, string Author, string Title, int CatalogNumber, string Publisher, string Genre, string ReleaseDate) : base(ISBN, Author, Title, CatalogNumber, Publisher, Genre, ReleaseDate)
    {
        this._DeweyDec = DeweyDec;
    }

    public override void Display()
    {
        Console.WriteLine($"\nNon Fiction Book ---\nTitle: {_Title} \nAuthor: {_Author} \nPublisher: {_Publisher} \nLocation: {_DeweyDec} \nGenre: {_Genre} \nISBN: {_ISBN} \nRelease Date: {_ReleaseDate} \nCatalogNumber: {_CatalogNumber}");
    }
}