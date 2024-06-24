using Admin_user_post_tasks.UserNameSpace;

namespace Admin_user_post_tasks.NotificationNameSpace;

public class Notifications
{
    public int Id { get; set; }
    public string Text { get; set; }
    public DateTime DateTimes { get; set; }
    public User FromUser { get; set; }
    public Notifications(int id, string text, DateTime dateTimes, User fromUser)
    {
        Id = id;
        Text = text;
        DateTimes = dateTimes;
        FromUser = fromUser;
    }
    public override string ToString() =>
        $"Id:{Id}\nText:{Text}\nDateTimes:{DateTimes}\nFromUser:{FromUser}";

}
