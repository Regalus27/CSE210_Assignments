class Comment
{
    private string _comment;
    private string _username;
    public Comment(string username, string commentText)
    {
        SetCommentText(commentText);
        SetUsername(username);
    }

    private string GetCommentText()
    {
        return _comment;
    }

    public string GetCommentSummary()
    {
        return $"{GetUsername()} says:\n{GetCommentText()}";
    }

    private string GetUsername()
    {
        return _username;
    }

    private void SetCommentText(string commentText)
    {
        _comment = commentText;
    }

    private void SetUsername(string username)
    {
        _username = username;
    }
}