public class Comment
{
    private string _personName;
    private string _commentText;

    public Comment(string name, string comment)
    {
        _personName = name;
        _commentText = comment;
    }
    public string GetName()
    {
        return _personName;
    }
    public string GetText()
    {
        return _commentText;
    }
}