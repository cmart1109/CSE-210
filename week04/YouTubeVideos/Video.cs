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
    public string GetDisplayInfo()
    {
        return $"{_title}, from {_author}, with duration of {_length} seconds.";
    }
    public void StoreComments(Comment comment)
    {
        _comments.Add(comment);
    }
    public void ShowAllComments()
    {
        foreach (var comment in _comments)
        {
            Console.WriteLine(comment.GetCommentInfo());
        }
    }

}