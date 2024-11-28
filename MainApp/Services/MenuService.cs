using MainApp.Models;

namespace MainApp.Services;

public class MenuService
{
    private readonly UserService _userService = new();

    public void CreateUserDialog()
    {
        Console.Clear();

        User user = new();

        Console.WriteLine("Enter your first name:");
        user.FirstName = Console.ReadLine()!;

        Console.WriteLine("Enter your last name:");
        user.LastName = Console.ReadLine()!;

        Console.WriteLine("Enter your email:");
        user.Email = Console.ReadLine()!;

        _userService.Add(user);
    }

    public void ViewAllUserDialog() 
    {
        Console.Clear();

        var users = _userService.GetAll();

        foreach (var user in users)
        {
            Console.WriteLine($"{"Id:", -15}{user.Id}");
            Console.WriteLine($"{"Name:",-15}{user.FirstName} {user.LastName}");
            Console.WriteLine($"{"Email:",-15}{user.Email}");
            Console.WriteLine("");
        }

        Console.ReadKey();
    }
}
