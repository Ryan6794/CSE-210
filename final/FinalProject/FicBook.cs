
class FicBook : Book
{

    private string _AuthorCode;
    public FicBook(string AuthorCode, long ISBN, string Author, string Title, int CatalogNumber, string Publisher, string Genre, string ReleaseDate) : base(ISBN, Author, Title, CatalogNumber, Publisher, Genre, ReleaseDate)
    {
        this._AuthorCode = AuthorCode;
    }

    public override void Display()
    {
        Console.WriteLine($"Title: {_Title} Author: {_Author} Publisher: {_Publisher} Location: {_AuthorCode} Genre: {_Genre} ISBN: {_ISBN} Release Date: {_ReleaseDate} CatalogNumber: {_CatalogNumber}");
    }
}