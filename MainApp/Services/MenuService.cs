using MainApp.Models;

namespace MainApp.Services;

public class MenuService
{
    private readonly UserService _userService = new();

    public void CreateUserDialog()
    {

        User user = new();

        // Input: FirstName
        Console.WriteLine("Enter your first name:");
        user.FirstName = Console.ReadLine()!;

        // Input: LastName
        Console.WriteLine("Enter your last name:");
        user.LastName = Console.ReadLine()!;

        // Input: Email
        Console.WriteLine("Enter your email:");
        user.Email = Console.ReadLine()!;
        Console.WriteLine("");

        // Adding inputs to list as single user
        _userService.Add(user);
    }

    public void ViewAllUserDialog() 
    {

        var users = _userService.GetAll();

        foreach (var user in users)
        {
            Console.WriteLine($"{"Id:", -15}{user.Id}");
            Console.WriteLine($"{"Name:",-15}{user.FirstName} {user.LastName}");
            Console.WriteLine($"{"Email:",-15}{user.Email}");
            Console.WriteLine("");
        }

    }
}
