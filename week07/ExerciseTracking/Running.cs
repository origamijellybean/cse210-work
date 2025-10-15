public class Running : Activity
{
    private double _distance;

    public Running(string date, double activityLengthInMinutes, double distance)
    {
        _date = date;
        _activityLengthInMinutes = activityLengthInMinutes;
        _distance = distance;
        _activityType = "Running";
    }   
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return _distance / _activityLengthInMinutes * 60;
    }
    public override double GetPace()
    {
        return _activityLengthInMinutes / _distance;
    }
}