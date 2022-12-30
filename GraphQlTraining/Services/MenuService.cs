using GraphQlTraining.Models;
using GraphQlTraining.Services.Interfaces;

namespace GraphQlTraining.Services
{
    public class MenuService : IMenuService
    {
        private List<Menu> _menuList = new List<Menu>
        {
            new Menu
            {
                Id = 1,
                Name = "ColdDrinks",
                ImageURL = "urlsone"
            },
            new Menu
            {
                Id = 2,
                Name = "Coffee",
                ImageURL = "urlstwo"
            },
            new Menu
            {
                Id = 3,
                Name = "Fod",
                ImageURL = "urlsthree"
            }
        };
        public Menu? GetMenuById(int id)
        {
            return _menuList.FirstOrDefault(m => m.Id == id);
        }

        public List<Menu> GetMenus()
        {
            return _menuList;
        }
    }
}
