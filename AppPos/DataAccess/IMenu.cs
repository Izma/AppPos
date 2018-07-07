using AppPos.Models;
using System.Threading.Tasks;

namespace AppPos.DataAccess
{
    public interface IMenu
    {
        Task<int> AddMenu(MenuModel model);
    }
}
