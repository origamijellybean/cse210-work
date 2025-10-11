public class SimpleGoal : Goal
{
    public SimpleGoal(List<string> fileData)
    {
        _goalType = fileData[0];
        _goalName = fileData[1];
        _goalDescription = fileData[2];
        _timesCompleted = int.Parse(fileData[3].Trim());
        _scoreValue = int.Parse(fileData[4].Trim());
    }
    public override void RecordEvent()
    {

    }

    public override string GetData()
    {
        return $"[{(_timesCompleted == 1 ? "X" : " ")}] Simple Goal: {_goalName}({_goalDescription}) Points earned: {_scoreValue * _timesCompleted}/{_scoreValue}";
    }
    public override string GetStoreData()
    {
        return $"{_goalType}|{_goalName}|{_goalDescription}|{_timesCompleted}|{_scoreValue}";
    }
    public override int CalculatePoints()
    {
        return _scoreValue * _timesCompleted;
    }
}
    