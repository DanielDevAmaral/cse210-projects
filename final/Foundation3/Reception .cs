class Reception : Event
{
    private string rsvpEmail;

    public Reception(string title, string description, DateTime date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        rsvpEmail = rsvpEmail;
    }

    public new string GetFullDetails()
    {
        return $"Type: Reception\n{base.GetFullDetails()}\nRSVP Email: {rsvpEmail}";
    }
}