public class Video
{
    private string _title;
    private string _author;
    private string _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, string length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void StoreComments(Comment comment)
    {
        _comments.Add(comment);
    }
    public void ShowAllContent()
    {
        Console.WriteLine($"{_title}, author: {_author}, length: {_length} seconds.");
        Console.WriteLine("Comments of the video");
        foreach (var comment in _comments)
        {
            
            Console.WriteLine(comment.GetCommentInfo());
        }
    }

}