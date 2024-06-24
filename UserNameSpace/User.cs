namespace Admin_user_post_tasks.UserNameSpace;

public class User
{


    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public User(int id, string name, string surname, int age, string email, string password)
    {
        Id = id;
        Name = name;
        Surname = surname;
        Age = age;
        Email = email;
        Password = password;
    }

    public override string ToString()
        => $"Id:{Id}\nName:{Name}\nSurname:{Surname}\nAge:{Age}\nEmail:{Email}\nPassword:{Password}";
}
