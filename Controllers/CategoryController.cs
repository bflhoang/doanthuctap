using Microsoft.AspNetCore.Mvc;

namespace BeeComputer.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
