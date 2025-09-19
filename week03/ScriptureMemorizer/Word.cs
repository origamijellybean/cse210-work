public class Word
{
    private string _word;
    private bool _show = true;


    public Word(string word)
    {
        _word = word;
    }
    //returns the word, or a string of "_" if '_show' is "false"
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
    public void ChangeVisibility()
    {
        _show = false;
    }
    public void SetNewWord(string word)
    {
        _word = word;
    }
}