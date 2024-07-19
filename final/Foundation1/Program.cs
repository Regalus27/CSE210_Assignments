using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Video> videos = [];
        for(int i = 0; i < 3; i++)
        {
            List<Comment> comments = [];
            comments.Add(new("user1", "first comment! " + i));
            comments.Add(new("ahgasd" + i, "first!"));
            comments.Add(new("user1", "no mine was first!!!"));
            Video video = new("Video #" + i, "VideoDude35", 55 + i * 32, comments);
            videos.Add(video);
        }
        foreach (Video v in videos)
        {
            Console.WriteLine(v.GetVideoSummary());
        }
    }
}