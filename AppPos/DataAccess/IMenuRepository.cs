using AppPos.Models;
using System.Linq;
using System.Threading.Tasks;

namespace AppPos.DataAccess
{
    public interface IMenuRepository
    {
        Task<int> AddMenu(MenuModel model);
        Task<IQueryable<MenuModel>> GetMenuList(int userId);
    }
}
