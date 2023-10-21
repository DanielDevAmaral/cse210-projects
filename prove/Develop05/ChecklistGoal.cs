class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        _amountCompleted ++;
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetDetailsString()
    {
        /*This method should return the details of a goal 
        that could be shown in a list. It should include the checkbox, 
        the short name, and description. Then in the case of the 
        ChecklistGoal class, it should be overridden to shown the number 
        of times the goal has been accomplished so far.*/

        return $"-- Currently completed: {_amountCompleted}/{_target}";

    }
    public override string GetStringRepresentation()
    {
        return $"Checklist Goal, {base.ShortName()}, {base.Description}.{base._points},{_target}, {_bonus}, {_amountCompleted}";
    }
}