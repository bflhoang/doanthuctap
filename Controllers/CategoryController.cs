using Microsoft.AspNetCore.Mvc;

namespace BeeComputer.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
