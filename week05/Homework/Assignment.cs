public class Assignment
{
    protected string _studentName = "";
    protected string _topic = "";

    public void SetName(string name)
    {
        _studentName = name;
    }
    public string GetName()
    {
        return _studentName;
    }
    public void SetTopic(string topic)
    {
        _topic = topic;
    }
    public string GetTopic()
    {
        return _topic;
    }

    public Assignment()
    {
    }
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }

}