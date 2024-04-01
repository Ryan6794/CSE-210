
class FicBook : Book
{

    private string _AuthorCode;
    public FicBook(string AuthorCode, long ISBN, string Author, string Title, int CatalogNumber, string Publisher, string Genre, string ReleaseDate) : base(ISBN, Author, Title, CatalogNumber, Publisher, Genre, ReleaseDate)
    {
        this._AuthorCode = AuthorCode;
    }

    public override void Display()
    {
        Console.WriteLine($"\nFiction Book ---\nTitle: {_Title} \nAuthor: {_Author} \nPublisher: {_Publisher} \nLocation: {_AuthorCode} \nGenre: {_Genre} \nISBN: {_ISBN} \nRelease Date: {_ReleaseDate} \nCatalogNumber: {_CatalogNumber}");
    }
}