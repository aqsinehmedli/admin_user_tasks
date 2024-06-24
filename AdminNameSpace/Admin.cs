using Admin_user_post_tasks.PostNameSpace;

namespace Admin_user_post_tasks.AdminNameSpace;

public class Admin
{


    public int Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string password { get; set; }
    public List<Post> Posts { get; set; }
    public Admin(int id, string username, string email, string password, List<Post> posts)
    {
        Id = id;
        Username = username;
        Email = email;
        this.password = password;
        Posts = posts;
    }

    public override string ToString() =>
        $"Id:{Id}\nUsername:{Username}\nEmail:{Email}\nPassword:{password}\nPosts:{Posts}";
}
