using System.Threading.Tasks;
using System.Web.Mvc;
using AppPos.Core;

namespace AppPos.Controllers
{
    public class MenuController : Controller
    {
        private readonly IMenu menu;
        public MenuController(IMenu _menu)
        {
            menu = _menu;
        }


        [HttpGet]
        public async Task<JsonResult> GetMenu(int userId)
        {
            return Json(await menu.GetMenu(userId), JsonRequestBehavior.AllowGet);
        }
    }
}