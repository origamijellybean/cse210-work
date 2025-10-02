public class MathAssignment : Assignment
{
    private string _textbookSection = "";
    private string _problems = "";

    public void SetSection(string section)
    {
        _textbookSection = section;
    }
    public string GetSection()
    {
        return _textbookSection;
    }

    public void SetProblems(string problems)
    {
        _problems = problems;
    }
    public string GetProblems()
    {
        return _problems;
    }

    public MathAssignment() : base()
    {
    }
    public MathAssignment(string name, string topic, string textbookSection, string problems) : base(name, topic)
    {

        _textbookSection = textbookSection;
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        return $"Section: {_textbookSection}\nProblems: {_problems}";
    }



}