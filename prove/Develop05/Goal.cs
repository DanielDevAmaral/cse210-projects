abstract class Goal 
{
    private string _shortName;
    private string _description;
    public string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public string ShortName()
    {
        return _shortName;
    }
    public string Description()
    {
        return _description;
    }
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();
}