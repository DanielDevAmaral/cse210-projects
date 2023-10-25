class OutdoorGathering : Event
{
    private string weatherStatement;

    public OutdoorGathering(string title, string description, DateTime date, string time, Address address, string weatherStatement)
        : base(title, description, date, time, address)
    {
        this.weatherStatement = weatherStatement;
    }

    public new string GetFullDetails()
    {
        return $"Type: Outdoor Gathering\n{base.GetFullDetails()}\nWeather Statement: {weatherStatement}";
    }
}