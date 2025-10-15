using System;
public abstract class Activity
{
    protected string _date;
    protected double _activityLengthInMinutes;
    protected string _activityType;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public string GetSummary()
    {
        return $"{_date} {_activityType} ({_activityLengthInMinutes})- Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }

    public void SetActivityLength(float length)
    {
        _activityLengthInMinutes = length;
    }
}
