public class Cycling : Activity
{
    private double _speed;
    public Cycling(string date, double activityLengthInMinutes, double speed)
    {
        _date = date;
        _activityLengthInMinutes = activityLengthInMinutes;
        _speed = speed;
        _activityType = "Cycling";
    }   
    public override double GetDistance()
    {
        return _activityLengthInMinutes * _speed / 60;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60/_speed;
    }
}