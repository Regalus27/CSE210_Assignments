class Video
{
    private List<Comment> _comments;
    private string _title;
    private string _creator;
    private int _videoDurationInSeconds;

    public Video(string title, string creator, int videoDurationInSeconds, List<Comment> comments)
    {
        SetComments(comments);
        SetTitle(title);
        SetCreator(creator);
        SetVideoDuration(videoDurationInSeconds);
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public string GetVideoSummary()
    {
        string summary = $"\"{GetTitle()}\" by {GetCreator()}. Duration: {GetFormattedDuration()}";
        summary += $"\n{GetNumberComments()} Comments:\n";
        foreach (Comment comment in GetComments())
        {
            summary += comment.GetCommentSummary() + "\n";
        }
        return summary;
    }

    public int GetNumberComments()
    {
        return GetComments().Count;
    }

    private List<Comment> GetComments()
    {
        return _comments;
    }

    private string GetTitle()
    {
        return _title;
    }

    private string GetCreator()
    {
        return _creator;
    }

    private int GetDuration()
    {
        return _videoDurationInSeconds;
    }

    private string GetFormattedDuration()
    {
        int minutes = GetDuration() / 60;
        int seconds = GetDuration() % 60;
        return $"{minutes}:{seconds}";
    }
    
    private void SetComments(List<Comment> comments)
    {
        _comments = comments;
    }

    private void SetTitle(string title)
    {
        _title = title;
    }

    private void SetCreator(string creator)
    {
        _creator = creator;
    }

    private void SetVideoDuration(int videoDurationInSeconds)
    {
        if(videoDurationInSeconds < 0){
            videoDurationInSeconds = 0;
        }
        _videoDurationInSeconds = videoDurationInSeconds;
    }
}