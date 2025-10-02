public class WritingAssignment : Assignment
{
    private string _title = "";

    public void SetTitle(string title)
    {
        _title = title;
    }
    public string GetTitle()
    {
        return _title;
    }
    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {

        return $"Topic: {_topic}\n{_title} by {_studentName}";
    }


}