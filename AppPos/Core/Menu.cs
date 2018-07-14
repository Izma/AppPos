using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using AppPos.Models;
using AppPos.DataAccess;

namespace AppPos.Core
{
    public class Menu : IMenu
    {
        private readonly IMenuRepository repository;

        public Menu(IMenuRepository menuRepository)
        {
            repository = menuRepository;
        }
        public async Task<List<MenuModel>> GetMenu(int userId)
        {
            var menu = await repository.GetMenuList(userId);
            var menuChild = new List<MenuModel>();
            foreach (var item in menu)
            {
                if (item.ParentId == 0)
                    menuChild.Add(new MenuModel
                    {
                        MenuId = item.MenuId,
                        Name = item.Name,
                        Order = item.Order,
                        Url = item.Url,
                        Icon = item.Icon,
                        MenuChild = menu.Where(x => x.ParentId == item.MenuId).ToList()
                    });
            }
            return menuChild;
        }
    }
}