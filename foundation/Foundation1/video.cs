using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _seconds;
    private List<Comments>();

    public Video(string title, string author, int length)
    {
        title = title;
        author = author;
        length = length;
        Comments = new List<Comments>();
    }

    public int GeNumberOfComments()
    {
        return Comments.Count;
    }

    public void DisplayAllComments()
    {
        foreach (Comments c in Comments)
            {
                Comments.DisplayComments()
            }
    }





}