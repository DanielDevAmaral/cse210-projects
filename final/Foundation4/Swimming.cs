class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int minutes, int laps)
        : base(date, minutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50.0 / 1000.0; // Convert laps to kilometers
    }

    public override double GetSpeed()
    {
        return (laps * 50.0 / 1000.0) / (minutes / 60.0);
    }

    public override double GetPace()
    {
        return minutes / (laps * 50.0 / 1000.0);
    }

    protected override string GetActivityType()
    {
        return "Swimming";
    }

    protected override string GetDistanceUnit()
    {
        return "km";
    }

    protected override string GetSpeedUnit()
    {
        return "kph";
    }

    protected override string GetPaceUnit()
    {
        return "minutes per km";
    }
}