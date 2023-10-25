class Activity
{
    private DateTime date;
    protected int minutes;

    public Activity(DateTime date, int minutes)
    {
        this.date = date;
        this.minutes = minutes;
    }
    public virtual double GetDistance()
    {
        return 0.0;
    }

    public virtual double GetSpeed()
    {
        return 0.0;
    }

    public virtual double GetPace()
    {
        return 0.0;
    }

    public string GetSummary()
    {
        return $"{date:dd MMM yyyy} {GetActivityType()} ({minutes} min) - Distance: {GetDistance():F1} {GetDistanceUnit()}, Speed: {GetSpeed():F1} {GetSpeedUnit()}, Pace: {GetPace():F1} {GetPaceUnit()}";
    }

    protected virtual string GetActivityType()
    {
        return "Activity";
    }

    protected virtual string GetDistanceUnit()
    {
        return "units";
    }

    protected virtual string GetSpeedUnit()
    {
        return "units per hour";
    }

    protected virtual string GetPaceUnit()
    {
        return "minutes per unit";
    }
}