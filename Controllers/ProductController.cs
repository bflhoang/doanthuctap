using BeeComputer.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BeeComputer.Controllers
{
    public class ProductController : Controller
    {
        private readonly DataContext _dataContext;
        public ProductController(DataContext context)
        {
            _dataContext = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail(int Id)
        {
            if (Id == null) return RedirectToAction("Index");

            var productsById = _dataContext.Products.Where(p=>p.Id==Id).FirstOrDefault(p => p.Id == Id);
            return View(productsById);
        }
    }
}