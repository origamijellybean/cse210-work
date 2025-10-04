using System.ComponentModel.DataAnnotations;
using System.Dynamic;

public class RandomSelection
{
    private List<string> _list = [];
    private List<string> _scrambleList = [];
    private int position = -1;

    public RandomSelection(List<string> list)
    {
        _list = list;
        CreateRandomList();
    }
    private void CreateRandomList()
    {
        Random random = new Random();
        _scrambleList = _list.OrderBy(n => random.Next()).ToList();
    }

    public string GetNextItem()
    {
        if (position < _scrambleList.Count() - 1)
            position += 1;
        else
            position = 0;
        return _scrambleList[position];
    }
    }