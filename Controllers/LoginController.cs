using Microsoft.AspNetCore.Mvc;

namespace BeeComputer.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
