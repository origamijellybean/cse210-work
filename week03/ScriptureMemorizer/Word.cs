public class Word
{
    private string _word;
    private bool _show = true;

    public Word(string word)
    {
        _word = word;
    }
    public string GetWord()
    {
        string word = "";
        if (_show == false)
        {
            foreach (char character in _word)
            {
                word += "_";
            }
        }
        else
        {
            word = _word;
        }
        return word;
    }

    public void SetWord(string word)
    {
        _word = word;
    }

    public void ChangeVisibility()
    {
        _show = false;
    }
}