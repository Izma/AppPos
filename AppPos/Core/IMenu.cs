using AppPos.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPos.Core
{
    public interface IMenu
    {
        Task<List<MenuModel>> GetMenu(int userId);
    }
}
