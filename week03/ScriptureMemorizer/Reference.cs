public class Reference
{
    private string _reference = "John 3:16";

    public string GetReference()
    {
        return _reference;
    }

    public void SetReference(string newReference)
    {
        _reference = newReference;
    }

    public void DisplayReference()
    {
        Console.Write(_reference);
    }
}