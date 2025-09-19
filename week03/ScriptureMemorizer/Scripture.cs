using System.ComponentModel.DataAnnotations;

public class Scripture
{
    private string _scripture = "For God so loved the world that he gave His only begotten son, that whosoever believeth in Him should not parish, but have everlasting life.";
    private List<Word> _words = [];
    private string[] _wordList = [];
    private List<int> _scrambleList = [];
    private int _scrambleCounter = 0;

    public Scripture()
    {
        _wordList = _scripture.Split(" ");
        foreach (string word in _wordList)
        {
            _words.Add(new Word(word));
        }
        Random random = new Random();
        _scrambleList = Enumerable.Range(0, _wordList.Count()).ToList();
        _scrambleList = _scrambleList.OrderBy(n => random.Next()).ToList();
    }

    public void DisplayScripture()
    {
        foreach (Word word in _words)
        {
            Console.Write($" {word.GetWord()}");
        }
        Console.WriteLine();
    }

    public bool RemoveWords()
    {

        if (_words.Count <= _scrambleCounter)
        {
            return false;
        }
        int i = 0;
        while (_words.Count > _scrambleCounter && i <= 2)
        {
            _words[_scrambleList[_scrambleCounter]].ChangeVisibility();
            _scrambleCounter += 1;
            i += 1;
        }
        return true;
    }

    public string GetScripture()
    {
        return _scripture;
    }
    public void SetScripture(string newScripture)
    {
        _scripture = newScripture;
    }

}