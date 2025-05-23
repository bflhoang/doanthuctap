﻿using BeeComputer.Models;
using BeeComputer.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BeeComputer.Controllers
{
    public class CategoryController : Controller
    {
        private readonly DataContext _dataContext;
        public CategoryController(DataContext context)
        {
            _dataContext = context;
        }
        public async Task<IActionResult> Index(string slug = "", string sort_by = "", string startprice = "", string endprice = "")
        {
            CategoryModel category = _dataContext.Categories.Where(c => c.Slug == slug).FirstOrDefault();
            if (category == null)
            {
                return RedirectToAction("Index", "Home");
            }
            var productsByCategory = _dataContext.Products.Where(p => p.CategoryId == category.Id);
            return View(await productsByCategory.OrderByDescending(p => p.Id).ToListAsync());
        }
    }
}
