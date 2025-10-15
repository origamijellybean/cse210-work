public class Swimming : Activity
{
    private double _laps;
    private int _poolLengthInMeters = 50;
    public Swimming(string date, double activityLengthInMinutes, double laps)
    {
        _date = date;
        _activityLengthInMinutes = activityLengthInMinutes;
        _laps = laps;
        _activityType = "Swimming";
    }   
    public override double GetDistance()
    {
        return _laps * _poolLengthInMeters / 1000 * 0.62;
    }
    public override double GetSpeed()
    {
        return GetDistance() / _activityLengthInMinutes * 60;
    }
    public override double GetPace()
    {
        return _activityLengthInMinutes / GetDistance();
    }
}