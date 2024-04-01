
class Magazine : Material
{
    private string _Illustrator;
    public Magazine(string Illustrator, string Title, int CatalogNumber, string Publisher, string Genre, string ReleaseDate) : base(Title, CatalogNumber, Publisher, Genre, ReleaseDate)
    {
        this._Illustrator = Illustrator;
    }

    public override void Display()
    {
        Console.WriteLine($"\nMagazine --- \nTitle: {_Title} \nPublisher: {_Publisher} \nIllustrator or Photographer: {_Illustrator} \nGenre: {_Genre} \nRelease Date: {_ReleaseDate} \nCatalogNumber: {_CatalogNumber}");
    }
}