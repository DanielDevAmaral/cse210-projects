public class Resume
{
    public string _personName;
    public List<Job> jobs = new List<Job>();

    public void Display() 
    {
      Console.WriteLine($"Name: {_personName}");
      Console.WriteLine($"Jobs:");
       foreach (Job i in jobs) 
        {
            i.Display();
        }
    }

}