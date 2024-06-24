
using Admin_user_post_tasks.AdminNameSpace;
using Admin_user_post_tasks.NotificationNameSpace;
using Admin_user_post_tasks.PostNameSpace;
using Admin_user_post_tasks.UserNameSpace;

//Posts
Post post1 = new Post(1, "FutbolPlayer1", new DateTime(2024, 01, 23), 50, 120);
Post post2 = new Post(2, "VoleybolPlayer1", new DateTime(2024, 02, 24), 100, 200);

//Lists

List<Post> posts = new List<Post>();
posts.Add(post1);
posts.Add(post2);

//Admin
Admin admin1 = new Admin(1, "aqsin1234", "aqsinehmdli03@gmail.com", "12345", posts);

//Users
User user1 = new User(1, "Revan", "Agazade", 20, "agazade12@gmail.com", "54321");

//Notifications
Notifications notifications1 = new Notifications(1, $"Postunuz {user1} terefinden beğenildi", new DateTime(2024, 05, 12), user1);
Notifications notifications2 = new Notifications(3, $"Postunuza {user1} terefinden baxildi", new DateTime(2024, 07, 02), user1);

//Display

void Display()
{
    Console.WriteLine("Nece daxil olmaq isteyirsiniz?");
    Console.WriteLine("1.Admin");
    Console.WriteLine("2.User");
    Console.Write("Choice:");
    string choice = Console.ReadLine();
    if (choice == "1")
    {
        Console.Write("AdminName:");
        string AdminName = Console.ReadLine();
        Console.Write("Password:");
        string password1 = Console.ReadLine();
        if (AdminName == admin1.Username && password1 == admin1.password)
        {
            Console.WriteLine("Giris ugurludur!");
            foreach (Post item in posts)
            {
                Console.WriteLine(item);
            }
        }
        throw new Exception("Username ve ya password yanlisdir!");
    }
    else if (choice == "2")
    {
        Console.Write("Gmail:");
        string gmail = Console.ReadLine();
        Console.Write("Password:");
        string password2 = Console.ReadLine();
        if (gmail == user1.Email && password2 == user1.Password)
        {
            Console.WriteLine("Giris ugurludur!");
            Console.WriteLine(user1);
            Console.Write("Baxmag istediyiniz postun Id - i daxil edin:");
            string id1 = Console.ReadLine();
            if (id1 == "1")
            {
                Console.WriteLine(notifications2);
                post1.ViewCount++;
                Console.WriteLine(post1);
                Console.WriteLine("Bu post - u beyenmek isteyirsiz?");
                Console.WriteLine("1.He");
                Console.WriteLine("2.Xeyr");
                string secim = Console.ReadLine();
                if (secim == "1")
                {
                    post1.LikeCount++;
                    Console.WriteLine(post1);
                }
            }
            else if (id1 == "2")
            {
                Console.WriteLine(post2);
                Console.WriteLine(notifications1);
                post2.ViewCount++;
                string secim2 =Console.ReadLine();
                if (secim2 == "2")
                {
                    post2.LikeCount++;
                }
               
            }

        }
        throw new Exception("Username ve ya password yanlisdir!");
    }
    else
    {
        throw new Exception("Qeyd etdiyiniz id - e uygun user ve ya admin yoxdur!");
    }

}
Display();

//Exception handling

try
{
    Display();
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}
















