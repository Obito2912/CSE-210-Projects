public class Comment
{
    public string _name;
    public string _comment;

public Comment(string name, string comment)
{
    _name = name;
    _comment = comment;
}

public string CommentInfo()
{
    return $"{_name} commented: {_comment}";
}
}