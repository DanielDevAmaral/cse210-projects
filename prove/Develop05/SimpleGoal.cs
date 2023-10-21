using System.Reflection.Metadata;

class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {

        _isComplete = false;
    }
    public override void RecordEvent()
    {
        /*This method should do whatever is necessary for each 
        specific kind of goal, such as marking a simple goal 
        complete and adding to the number of times a checklist 
        goal has been completed. It should return the point 
        value associated with recording the event 
        (keep in mind that it may contain a bonus in some 
        cases if a checklist goal was just finished, for example). */
        IsComplete();
        
        

    }
    public override bool IsComplete()
    {
        /*This method should return true if the goal is completed. The way you 
        determine if a goal is complete is different for each type of goal.*/
        return true;
    }

    /*In addition to recording the event and checking if it is complete. 
    Each goal will need to be shown in a list (with the checkbox etc), 
    and also each one will need a string representation that can be 
    saved to a text file. These should also be declared in the base class 
    and overridden in the derived classes as needed:*/

    public override string GetStringRepresentation()
    {
        /*This method should provide all of the details 
        of a goal in a way that is easy to save to a file, 
        and then load later.*/
        return $"Checklist Goal, {base.ShortName()}, {base.Description}";

    }
        public override string GetDetailsString()
    {
        return $"{base.ShortName()} {base.Description()} {base._points}";
    }

}