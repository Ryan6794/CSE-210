
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
        Console.WriteLine($"Title: {_Title} Publisher: {_Publisher} Rating: {_Rating} Length: {_WatchTime} Genre: {_Genre} Release Date: {_ReleaseDate} CatalogNumber: {_CatalogNumber}");
    }

}