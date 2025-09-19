public class Reference
{
    private string _reference = "John 3:16";

    public Reference(string reference)
    {
        _reference = reference;
    }
    public void DisplayReference()
    {
        Console.Write(_reference);
    }
    public string GetReference()
    {
        return _reference;
    }
    public void SetNewReference(string newReference)
    {
        _reference = newReference;
    }


}