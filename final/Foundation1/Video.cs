using System.ComponentModel.Design.Serialization;
using System.Transactions;

class Video
{
    public string _title;
    public string _author;
    public double _length;
    public List<Comment> _comments = new List<Comment>();

    public Video (string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    
    public void ListOfComments(Comment comment)
    {
        _comments.Add(comment);
    }
    public int NumberOfComents()
    {
        int numberofcommnets = _comments.Count;
        return numberofcommnets;
    }

    public void Display()
    {
        Console.WriteLine($"The {_title} Video");
        Console.WriteLine($"from: {_author} has: {_length} seconds");
        Console.WriteLine($"The video has {NumberOfComents()} number of comments. See the comments bellow:");
        foreach(Comment comment in _comments)
        {
            Console.WriteLine($"{comment._personName} comments: ");
            Console.WriteLine($"{comment._comment}");
        }

    }

}