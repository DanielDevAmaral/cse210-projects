class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {

    }
    public override void RecordEvent()
    {

    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"Checklist Goal, {base.ShortName()}, {base.Description}";
  
    }
    public override string GetDetailsString()
    {
        return $"{base.ShortName()} {base.Description()} {base._points}";
    }

}