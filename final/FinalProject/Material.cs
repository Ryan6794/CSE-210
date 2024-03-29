

abstract class Material
{
    protected string _Title;
    protected int _CatalogNumber;
    protected string _Publisher;
    protected string _Genre;
    protected string _ReleaseDate;


    public Material(string Title, int CatalogNumber, string Publisher, string Genre, string ReleaseDate)
    {
        this._Title = Title;
        this._CatalogNumber = CatalogNumber;
        this._Publisher = Publisher;
        this._Genre = Genre;
        this._ReleaseDate = ReleaseDate;
    }


    abstract public void Display();

}