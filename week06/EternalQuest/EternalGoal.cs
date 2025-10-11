public class EternalGoal : Goal
{
    public EternalGoal(List<string> fileData)
    {
        _goalType = fileData[0];
        _goalName = fileData[1];
        _goalDescription = fileData[2];
        _timesCompleted = int.Parse(fileData[3].Trim());
        _scoreValue = int.Parse(fileData[4].Trim());
    }
    public override void RecordEvent()
    {
        _timesCompleted += 1;
    }

    public override string GetData()
    {
        return $"[ ] Eternal Goal: {_goalName}({_goalDescription}) Times Completed: {_timesCompleted} Points earned: {_scoreValue * _timesCompleted}";

    }
    public override string GetStoreData()
    {
        return $"{_goalType}|{_goalName}|{_goalDescription}|{_timesCompleted}|{_scoreValue}";
    }
    public override int CalculatePoints()
    {
        return _timesCompleted * _scoreValue;
    }
}