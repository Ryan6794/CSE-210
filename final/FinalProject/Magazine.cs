
class Magazine : Material
{
    private string _Illustrator;
    public Magazine(string Illustrator, string Title, int CatalogNumber, string Publisher, string Genre, string ReleaseDate) : base(Title, CatalogNumber, Publisher, Genre, ReleaseDate)
    {
        this._Illustrator = Illustrator;
    }

    public override void Display()
    {
        Console.WriteLine($"Title: {_Title} Publisher: {_Publisher} Illustrator or Photographer: {_Illustrator} Genre: {_Genre} Release Date: {_ReleaseDate} CatalogNumber: {_CatalogNumber}");
    }
}