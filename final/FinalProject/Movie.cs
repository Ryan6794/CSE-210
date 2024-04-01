
class Movie : Material
{
    private string _Rating;
    private string _WatchTime;

    public Movie(string Rating, string WatchTime, string Title, int CatalogNumber, string Publisher, string Genre, string ReleaseDate) : base(Title, CatalogNumber, Publisher, Genre, ReleaseDate)
    {
        this._Rating = Rating;
        this._WatchTime = WatchTime;
    }

    public override void Display()
    {
        Console.WriteLine($"\nMovie --- \nTitle: {_Title} \nPublisher: {_Publisher} \nRating: {_Rating} \nLength: {_WatchTime} \nGenre: {_Genre} \nRelease Date: {_ReleaseDate} \nCatalogNumber: {_CatalogNumber}");
    }

}