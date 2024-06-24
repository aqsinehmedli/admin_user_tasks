namespace Admin_user_post_tasks.PostNameSpace;

public class Post
{


    public int Id { get; set; }
    public string Content { get; set; }
    public DateTime CreationDateTime { get; set; }
    public int LikeCount { get; set; }
    public int ViewCount { get; set; }

    public Post(int id, string content, DateTime creationDateTime, int likeCount, int viewCount)
    {
        Id = id;
        Content = content;
        CreationDateTime = creationDateTime;
        LikeCount = likeCount;
        ViewCount = viewCount;
    }

    public override string ToString() =>
        $"Id:{Id}\nContent:{Content}\nCreationDateTime:{CreationDateTime}\nLikeCount:{LikeCount}\nViewCount:{ViewCount}";
}
