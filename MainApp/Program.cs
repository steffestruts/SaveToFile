using MainApp.Services;

var menuService = new MenuService();

while (true)
{
    menuService.CreateUserDialog();
    menuService.ViewAllUserDialog();
}