public class ChecklistGoal : Goal
{
    private int _bonusPointValue;
    private int _maxTimesCompleted;

    public ChecklistGoal(List<string> fileData)
    {
        _goalType = fileData[0];
        _goalName = fileData[1];
        _goalDescription = fileData[2];
        _timesCompleted = int.Parse(fileData[3].Trim());
        _scoreValue = int.Parse(fileData[4].Trim());
        _maxTimesCompleted = int.Parse(fileData[5].Trim());
        _bonusPointValue = int.Parse(fileData[6].Trim());
    }
    public override void RecordEvent()
    {
        _timesCompleted += _timesCompleted < _maxTimesCompleted? 1 : 0;
    }

    public override string GetData()
    {
        return $"[{(_timesCompleted == _maxTimesCompleted ? "X" : " ")}] Checklist Goal: {_goalName} ({_goalDescription}) Times completed: {_timesCompleted}/{_maxTimesCompleted} Points earned: {(_scoreValue * _timesCompleted) + (_timesCompleted == _maxTimesCompleted? _bonusPointValue : 0)}/{(_scoreValue * _maxTimesCompleted) + _bonusPointValue}";
    }

    public override string GetStoreData()
    {
        return $"{_goalType}|{ _goalName}|{_goalDescription}|{_timesCompleted}|{_scoreValue}|{_maxTimesCompleted}|{_bonusPointValue}";
    }

    public override int CalculatePoints()
    {
        return _scoreValue * _timesCompleted + _bonusPointValue * (_timesCompleted == _maxTimesCompleted?1:0);
    }
}