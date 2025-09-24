using System.Net;
using System.Reflection;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _vidLength;
    private List<Comment> comments = [];

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _vidLength = length;
    }

    public string GetTitle()
    {
        return _title;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public int GetLength()
    {
        return _vidLength;
    }

    public int GetNumComments()
    {
        return comments.Count;
    }
    public List<Comment> GetComments()
    {
        return comments;
    }

    public void EnterComment(string personName, string comment)
    {
        comments.Add(new Comment(personName, comment));
    }
}