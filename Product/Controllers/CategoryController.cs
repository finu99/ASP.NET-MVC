using Microsoft.AspNetCore.Mvc;
using Product.Data;
using Product.Models;

namespace Product.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryContext _dbContext;
        public CategoryController(CategoryContext db)
        {
            _dbContext = db;
        }
        

         public IActionResult Index()
        {
            //var objcategoryList = _dbContext.Categories.ToList();
            //return View();

            IEnumerable<Category> objcategoryList = _dbContext.Categories;
            return View(objcategoryList);   
        }
    }
}
