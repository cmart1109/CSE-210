using System.IO.Pipes;

public class Comment
{
    private string _name;
    private string _comment;

    public Comment(string user, string text)
    {
        _name = user;
        _comment = text;
        GetCommentInfo();
        
    } 
public string GetCommentInfo()
    {
        return $"{_name}:{_comment}";
    }
}