using MainApp.Services;

var menuService = new MenuService();

while (true)
{
    menuService.ViewAllUserDialog();
    menuService.CreateUserDialog();
}