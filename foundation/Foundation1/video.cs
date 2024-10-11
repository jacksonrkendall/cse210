using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _seconds;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _seconds = length;
        _comments = new List<Comment>();
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void DisplayAllComments()
    {
        foreach (Comment c in _comments)
            {
                c.DisplayComment();
            }
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_seconds} seconds");
        Console.WriteLine($"Number of comments: {GetNumberOfComments()}");
        DisplayAllComments();
    }



}