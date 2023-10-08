class Assignments
{
    protected string _studantName;
    private string _topic;

    public Assignments(string studentName, string topic)
    {
        _studantName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studantName} - {_topic}";
    }









}


