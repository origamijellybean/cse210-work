public abstract class Goal
{
    protected int _scoreValue;
    protected int _timesCompleted;
    protected string _goalName;
    protected string _goalType;
    protected string _goalDescription;

    public abstract string GetData();
    public abstract string GetStoreData();
    public abstract void RecordEvent();
    public abstract int CalculatePoints();

}