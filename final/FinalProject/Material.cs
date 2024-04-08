

abstract class Material
{
    protected string _title;
    protected int _catalogNumber;
    protected string _publisher;
    protected string _genre;
    protected string _releaseDate;


    public Material(string title, int catalogNumber, string publisher, string genre, string releaseDate)
    {
        this._title = title;
        this._catalogNumber = catalogNumber;
        this._publisher = publisher;
        this._genre = genre;
        this._releaseDate = releaseDate;
    }


    abstract public void Display();

}