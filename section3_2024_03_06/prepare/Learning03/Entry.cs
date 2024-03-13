namespace learning03;

public class Entry
{
    public readonly string DELIMETER = "~";

    public string prompt;
    public string content;
    public string date;
    public string tag;
}



/////////////////////////////////////////////////////////////




public class EntryBetter
{
    private readonly string DELIMETER = "~";

    private string prompt;
    private string content;
    private string date;
    private string tag;

    public EntryBetter(string prompt, string content, string tag)
    {
        this.prompt = prompt;
        this.content = content;
        this.tag = tag;
        this.date = DateTime.Now.ToShortDateString();
    }

    public string Export()
    {
        return $"{date}{DELIMETER}{prompt}{DELIMETER}{content}{DELIMETER}{tag}";
    }
}