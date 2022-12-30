using GraphQlTraining.Models;

namespace GraphQlTraining.Services.Interfaces
{
    public interface IMenuService
    {
        List<Menu> GetMenus();
        Menu? GetMenuById(int id);
    }
}
